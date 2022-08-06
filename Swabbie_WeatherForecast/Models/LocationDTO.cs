namespace Swabbie_WeatherForecast.Models
{
    public class LocationDTO
    {
        public string name { get; set; }
        public LocalNames local_names { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public string countryFlagImgSrc
        {
            get
            {
                return $"https://countryflagsapi.com/png/{country}";
            }
        }
    }
}
