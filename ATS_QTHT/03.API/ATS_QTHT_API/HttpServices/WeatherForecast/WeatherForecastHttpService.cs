using Confluent.Kafka;
using NetCore.Core.Helper;
using SV.QTHT.Core;

namespace ATS_QTHT_API.HttpServices.WeatherForecast
{
    public class WeatherForecastHttpService : IWeatherForecastHttpService
    {
        private HttpClient _client;
        private IHttpHelper _httpHelper;
        private IHttpContextAccessor _httpContextAccessor;

        public WeatherForecastHttpService(HttpClient client, IHttpContextAccessor httpContextAccessor)
        {
            _client = client;
            _httpContextAccessor = httpContextAccessor;
            _httpHelper = new HttpHelper(_client, _httpContextAccessor);
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<Response<string>> Get()
        {
            return await _httpHelper.GetAsync<Response<string>>($"WeatherForecast/Get");
        }
    }
}
