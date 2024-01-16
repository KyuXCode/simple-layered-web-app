using MathService;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", (int value) => "Here's the factorial of " + value + "=" + FactorialService.GetFactorialOf(value));

app.Run();
