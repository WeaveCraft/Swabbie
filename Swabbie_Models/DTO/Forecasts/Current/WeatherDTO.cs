namespace Swabbie_Models.DTO.Forecasts.Current
{
    public class WeatherDTO
    {
        public LocationDTO Location { get; set; }

        public CurrentWeatherDTO CurrentWeather { get; set; }

        public WeatherForecastDTO WeatherForecast { get; set; }
    }
}
