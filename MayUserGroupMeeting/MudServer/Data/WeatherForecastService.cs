namespace MudServer.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime fromDate, DateTime untilDate)
        {
            int countDays = (untilDate.Date - fromDate.Date).Days + 1;
            return Task.FromResult(Enumerable.Range(0, countDays).Select(index => new WeatherForecast
            {
                Date = fromDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray());

        }
    }
}
