var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

const string studentId = "25020007001"; 
const string form = "智能制造";       

app.MapGet("/lab1/status", () =>
{
    return $"EXPO-READY|{studentId}|{form}";
});

app.Run();