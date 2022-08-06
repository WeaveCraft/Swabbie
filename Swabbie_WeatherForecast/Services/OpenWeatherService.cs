using Microsoft.Extensions.Configuration;
using Swabbie_WeatherForecast;
using Swabbie_WeatherForecast.Models;
using Swabbie_WeatherForecast.Models.Current;
using Swabbie_WeatherForecast.Services;

public class OpenWeatherService : IOpenWeatherService
{
    private readonly HttpClient client;
    private readonly string apiKey;

    public OpenWeatherService(IConfiguration configuration)
    {
        client = new();
        apiKey = configuration["OpenWeatherAPIKey"];
    }

    public async Task<IEnumerable<LocationDTO>?> GetLocations(LocationSearchDTO locationSearchDTO)
    {
        IEnumerable<LocationDTO>? locations = null;
        string requestUri = GetGeoRequestUri(locationSearchDTO);

        HttpResponseMessage response = await client.GetAsync(requestUri);

        if (response.IsSuccessStatusCode)
            locations = await response.Content.ReadAsAsync<IEnumerable<LocationDTO>>();

        return locations;
    }

    private string GetGeoRequestUri(LocationSearchDTO locationSearchDTO) =>
        $"https://api.openweathermap.org/geo/1.0/direct?q={locationSearchDTO.Location}&limit=5&appid={apiKey}";

    private async Task<CurrentWeatherDTO> GetCurrentWeather(LocationDTO location)
    {
        CurrentWeatherDTO weatherForecast = new();
        string requestUri = GetCurrentWeatherRequestUri(location);

        HttpResponseMessage response = await client.GetAsync(requestUri);

        if (response.IsSuccessStatusCode)
            weatherForecast = await response.Content.ReadAsAsync<CurrentWeatherDTO>();

        return weatherForecast;
    }

    private string GetCurrentWeatherRequestUri(LocationDTO location) =>
                $"https://api.openweathermap.org/data/2.5/weather?lat={location.lat}&lon={location.lon}&units=metric&appid={apiKey}";

    private async Task<WeatherForecastDTO> GetWeatherForecast(LocationDTO location)
    {
        WeatherForecastDTO weatherForecast = new();
        string requestUri = GetWeatherForecastRequestUri(location);

        HttpResponseMessage response = await client.GetAsync(requestUri);

        if (response.IsSuccessStatusCode)
            weatherForecast = await response.Content.ReadAsAsync<WeatherForecastDTO>();

        return weatherForecast;
    }

    private string GetWeatherForecastRequestUri(LocationDTO location) =>
                $"https://api.openweathermap.org/data/2.5/forecast?lat={location.lat}&lon={location.lon}&units=metric&appid={apiKey}";

    public async Task<WeatherDTO> GetWeather(LocationDTO location)
    {
        return new WeatherDTO
        {
            Location = location,
            CurrentWeather = await GetCurrentWeather(location),
            WeatherForecast = await GetWeatherForecast(location)
        };
    }
}