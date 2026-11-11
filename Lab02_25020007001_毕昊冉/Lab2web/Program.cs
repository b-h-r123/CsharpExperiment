using System.Globalization;
using System.Text;
using Lab2.Services;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => Results.Text(
    "Lab2 展板边框计算 Web 端\n" +
    "接口：POST /api/frame/calculate（application/x-www-form-urlencoded，字段 width、height、border）"));

app.MapPost("/api/frame/calculate", async (HttpRequest request) =>
{
    IFormCollection form;
    try
    {
        form = await request.ReadFormAsync();
    }

    catch (Exception)
    {
        return BadRequest("请求体不是合法的表单数据，请检查 & 和 = 是否已正确编码");
    }

    if (!form.ContainsKey("width") || !form.ContainsKey("height") || !form.ContainsKey("border"))
    {
        return BadRequest("缺少 width、height 或 border 参数");
    }

    if (!TryParseNumber(form["width"], out double width))
    {
        return BadRequest("width 必须是数字");
    }

    if (!TryParseNumber(form["height"], out double height))
    {
        return BadRequest("height 必须是数字");
    }

    if (!TryParseNumber(form["border"], out double border))
    {
        return BadRequest("border 必须是数字");
    }

    if (!FrameCalculator.TryCalculate(
            width, height, border,
            out double displayArea, out double borderArea, out double outerPerimeter,
            out string? error))
    {
        return BadRequest(error!);
    }

    string result = new StringBuilder()
        .Append("displayArea: ").Append(FrameCalculator.Format(displayArea)).AppendLine(" cm²")
        .Append("borderArea: ").Append(FrameCalculator.Format(borderArea)).AppendLine(" cm²")
        .Append("outerPerimeter: ").Append(FrameCalculator.Format(outerPerimeter)).Append(" cm")
        .ToString();

    return Results.Text(result, "text/plain; charset=utf-8");
});

app.Run();

static IResult BadRequest(string message) =>
    Results.Text(message, "text/plain; charset=utf-8", statusCode: StatusCodes.Status400BadRequest);

static bool TryParseNumber(string? raw, out double value)
{
    value = 0;
    if (string.IsNullOrWhiteSpace(raw))
    {
        return false;
    }

    return double.TryParse(
        raw.Trim(),
        NumberStyles.Float,
        CultureInfo.InvariantCulture,
        out value);
}
