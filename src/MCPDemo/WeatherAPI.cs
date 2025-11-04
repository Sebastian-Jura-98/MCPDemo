namespace MCPDemo;

public static class WeatherAPI
{
    public static WebApplication AddWeatherAPI(this WebApplication app)
    {
        var summariesABC = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        app.MapGet("/coldestCity", () =>
        {
            return "Reykjavik";
        })
        .WithName("GetColdestCity");

        app.MapGet("/weatherforecast", () =>
        {
            var forecast = Enumerable.Range(1, 5).Select(index =>
                new WeatherForecast
                (
                    DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    Random.Shared.Next(-20, 55),
                    summariesABC[Random.Shared.Next(summariesABC.Length)],
                    "FooBar"
                ))
                .ToArray();
            return forecast;
        })
        .WithName("GetWeatherForecast");

        app.MapGet("/hottestCity", () =>
        {
            return "Kuwait City";
        })
        .WithName("GetHottestCity");

        return app;
    }

    internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary, string Foo)
    {
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}
