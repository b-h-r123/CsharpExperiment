using System.Globalization;

namespace Lab2.Services;

public static class FrameCalculator
{
    public const double MaxSide = 10000.0;

    public const string MissingFieldMessage = "缺少 width、height 或 border 参数";

    public static bool TryCalculate(
        double width,
        double height,
        double border,
        out double displayArea,
        out double borderArea,
        out double outerPerimeter,
        out string? error)
    {
        displayArea = 0;
        borderArea = 0;
        outerPerimeter = 0;
        error = null;

        if (!IsFinite(width) || !IsFinite(height) || !IsFinite(border))
        {
            error = "所有输入必须是有限实数";
            return false;
        }

        if (width <= 0 || width > MaxSide)
        {
            error = "width 必须满足 0 < width <= 10000";
            return false;
        }

        if (height <= 0 || height > MaxSide)
        {
            error = "height 必须满足 0 < height <= 10000";
            return false;
        }

        if (border <= 0)
        {
            error = "border 必须大于 0（边框宽度非正）";
            return false;
        }

        if (2 * border >= width)
        {
            error = "边框太宽：内部宽度 = width - 2 × border 必须大于 0";
            return false;
        }

        if (2 * border >= height)
        {
            error = "边框太宽：内部高度 = height - 2 × border 必须大于 0";
            return false;
        }

        double innerWidth = width - 2 * border;  
        double innerHeight = height - 2 * border; 

        displayArea = innerWidth * innerHeight;       
        borderArea = width * height - displayArea;    
        outerPerimeter = 2 * (width + height);        

        return true;
    }

    public static string Format(double value) =>
        value.ToString("F2", CultureInfo.InvariantCulture);

    private static bool IsFinite(double value) =>
        !double.IsNaN(value) && !double.IsInfinity(value);
}
