using MathService;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var value = 7;

app.MapGet("/", () => "Here's the result of " + value + "! = " + FactorialService.GetFactorialOf(value));

app.Run();
