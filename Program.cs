var builder = WebApplication.CreateBuilder();
builder.Services.AddTransient<CalcService>();
builder.Services.AddTransient<TimeOfDayService>();
var app = builder.Build();
app.Run(async context =>
{
    var timeOfDayService= app.Services.GetService<TimeOfDayService>();
    var �alcService = app.Services.GetService<CalcService>();

    await context.Response.WriteAsync($"Time: {timeOfDayService?.GetTimeOfDay()}");
    await context.Response.WriteAsync($"\nSum: {�alcService?.Add(1,2)}");
    await context.Response.WriteAsync($"\nMultiplication: {�alcService?.Multiplication(5, 5)}");

});
app.Run();
