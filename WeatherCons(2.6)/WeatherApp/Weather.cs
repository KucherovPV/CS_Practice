
namespace WeatherApp
{
    public class WeatherResponse
    {
        public string Name { get; set; }
        public MainInfo Main { get; set; }
        public WeatherInfo[] Weather { get; set; }
        public WindInfo Wind { get; set; }
    }


}