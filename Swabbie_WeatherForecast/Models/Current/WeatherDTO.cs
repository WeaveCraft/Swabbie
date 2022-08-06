namespace Swabbie_WeatherForecast.Models.Current
{
    public class WeatherDTO
    {
        public LocationDTO Location { get; set; }

        public CurrentWeatherDTO CurrentWeather { get; set; }

        public WeatherForecastDTO WeatherForecast { get; set; }
    }
}
