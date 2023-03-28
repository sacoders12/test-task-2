using Microsoft.EntityFrameworkCore;
using serverside.Context;
using serverside.Core.Errors;
using serverside.Response;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace serverside.Services.Weather
{
    public class WeatherHandler : IWeatherHandler
    {
        private readonly DatabaseContext _databaseContext;
        public WeatherHandler(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public async Task<(WeatherCityResponse, Error)> WeatherDataGet(string city)
        {
            try
            {
                if(string.IsNullOrEmpty(city))
                {
                    return (null, ErrorUtil.InputDataError);
                }
                var data = await _databaseContext.cities.Where(c => c.name == city)
                                 .Select(c => new WeatherCityResponse()
                                 {
                                     name = c.name,
                                     dew_point = c.dew_point,
                                     location = c.location,
                                     pressure = c.pressure,
                                     relative_humidility = c.relative_humidility,
                                     sky_condition = c.sky_condition,
                                     temp_celcius = c.temp_celcius,
                                     temp_fahrenheit = c.temp_fahrenheit,
                                     time = c.time,
                                     visibility = c.visibility,
                                     wind = c.wind
                                 }).FirstOrDefaultAsync();

                return (data, null);
            }
            catch
            {
                return (null, ErrorUtil.InternalServerError);
            }
        }

        public async Task<(List<CityResponse>, Error)> ListCity(string country)
        {
            try
            {
                if (string.IsNullOrEmpty(country))
                {
                    return (null, ErrorUtil.InputDataError);
                }
                var data = await _databaseContext.cities.Include(c => c.country).Where(c => c.country.name == country)
                            .Select(c => new CityResponse()
                            {
                                name = c.name,
                            }).ToListAsync();

                return (data,null);
            }
            catch
            {
                return (null, ErrorUtil.InternalServerError);
            }
        }

        public async Task<(List<CityResponse>, Error)> ListCountry()
        {
            try
            {
                var data = await _databaseContext.country.Select(c => new CityResponse()
                {
                    name = c.name
                }).ToListAsync();

                return (data, null);
            }
            catch
            {
                return (null, ErrorUtil.InternalServerError);
            }
        }


    }
}
