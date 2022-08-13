using System.ComponentModel.DataAnnotations;

namespace Swabbie_Models.DTO.Forecasts
{
    public class LocationSearchDTO
    {
        [Required]
        public string? Location { get; set; }
    }
}
