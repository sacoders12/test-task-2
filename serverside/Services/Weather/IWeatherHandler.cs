using serverside.Core.Errors;
using serverside.Response;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace serverside.Services.Weather
{
    public interface IWeatherHandler
    {
        Task<(WeatherCityResponse, Error)> WeatherDataGet(string city);
        Task<(List<CityResponse>, Error)> ListCity(string country);
        Task<(List<CityResponse>, Error)> ListCountry();
    }
}
