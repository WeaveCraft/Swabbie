using System.ComponentModel.DataAnnotations;

namespace Swabbie_WeatherForecast.Models
{
    public class LocationSearchDTO
    {
        [Required]
        public string? Location { get; set; }
    }
}
