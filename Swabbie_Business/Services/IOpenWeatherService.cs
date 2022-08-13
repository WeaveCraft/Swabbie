using Swabbie_Models.DTO.Forecasts;
using Swabbie_Models.DTO.Forecasts.Current;

namespace Swabbie_Business.Services
{
    public interface IOpenWeatherService
    {
        Task<IEnumerable<LocationDTO>?> GetLocations(LocationSearchDTO locationSearchDTO);
        Task<WeatherDTO> GetWeather(LocationDTO location);
    }
}
