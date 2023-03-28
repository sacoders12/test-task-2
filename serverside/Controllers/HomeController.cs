using Microsoft.AspNetCore.Mvc;
using serverside.Core.Responses;
using serverside.Response;
using serverside.Services.Weather;
using System.Threading.Tasks;

namespace serverside.Controllers
{
    [ApiController]
    [Route("api")]
    public class HomeController : ControllerBase
    {
        private readonly IWeatherHandler _weatherHandler;
        public HomeController(IWeatherHandler weatherHandler) 
        {
            _weatherHandler = weatherHandler;
        }

        public HomeController()
        {
        }

        [Route("country")]
        [HttpGet]
        [ProducesResponseType(typeof(GenericListResponse<CityResponse>), 200)]
        [ProducesResponseType(typeof(BasicResponse), 400)]
        public async Task<IActionResult> GetCountry()
        {
            var (data, err) = await _weatherHandler.ListCountry();
            if(err != null)
            {
                var errResponse = new BasicResponse()
                {
                    Error = err,
                    Message = err.message,
                    StatusCode = System.Net.HttpStatusCode.BadRequest
                };
                return Ok(errResponse);
            }

            var response = new GenericListResponse<CityResponse>()
            {
                Data = data
            };

            return Ok(response);
        }

        [Route("city")]
        [HttpGet]
        [ProducesResponseType(typeof(GenericListResponse<CityResponse>), 200)]
        [ProducesResponseType(typeof(BasicResponse), 400)]
        public async Task<IActionResult> GetCity(string country)
        {
            var (data, err) = await _weatherHandler.ListCity(country);
            if (err != null)
            {
                var errResponse = new BasicResponse()
                {
                    Error = err,
                    Message = err.message,
                    StatusCode = System.Net.HttpStatusCode.BadRequest
                };
                return Ok(errResponse);
            }

            var response = new GenericListResponse<CityResponse>()
            {
               Data = data
            };

            return Ok(response);
        }

        [Route("weather")]
        [HttpGet]
        [ProducesResponseType(typeof(GenericResponse<WeatherCityResponse>), 200)]
        [ProducesResponseType(typeof(BasicResponse), 400)]
        public async Task<IActionResult> Weather(string city)
        {
            var (data,err) = await _weatherHandler.WeatherDataGet(city);
            if (err != null)
            {
                var errResponse = new BasicResponse()
                {
                    Error = err,
                    Message = err.message,
                    StatusCode = System.Net.HttpStatusCode.BadRequest
                };
                return Ok(errResponse);
            }

            var response = new GenericResponse<WeatherCityResponse>()
            {
                Data = data
            };

            return Ok(response);
        }
    }
}
