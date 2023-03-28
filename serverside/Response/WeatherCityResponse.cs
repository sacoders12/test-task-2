using System;

namespace serverside.Response
{
    public class WeatherCityResponse
    {
        public string name { get; set; }
        public int location { get; set; }
        public DateTime time { get; set; }
        public int wind { get; set; }
        public int visibility { get; set; }
        public string sky_condition { get; set; }
        public int temp_celcius { get; set; }
        public int temp_fahrenheit { get; set; }
        public int dew_point { get; set; }
        public int relative_humidility { get; set; }
        public int pressure { get; set; }
    }
}
