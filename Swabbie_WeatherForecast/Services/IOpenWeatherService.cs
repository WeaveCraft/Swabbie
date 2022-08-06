using Swabbie_WeatherForecast.Models;
using Swabbie_WeatherForecast.Models.Current;

namespace Swabbie_WeatherForecast.Services
{
    public interface IOpenWeatherService
    {
        Task<IEnumerable<LocationDTO>?> GetLocations(LocationSearchDTO locationSearchDTO);
        Task<WeatherDTO> GetWeather(LocationDTO location);
    }
}
