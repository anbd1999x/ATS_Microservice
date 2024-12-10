using ATS_QTHT_API.HttpServices.WeatherForecast;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using SV.QTHT.Core;

namespace ATS_QTHT_API.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecastHttpService _IWeatherForecastHttpService;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastHttpService IWeatherForecastHttpService)
        {
            _logger = logger;
            _IWeatherForecastHttpService = IWeatherForecastHttpService;
        }
        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<Response<string>> Get()
        {
            return await _IWeatherForecastHttpService.Get();
        }
    }
}
