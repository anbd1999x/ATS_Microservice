using SV.QTHT.Core;

namespace ATS_QTHT_API.HttpServices.WeatherForecast
{
    public interface IWeatherForecastHttpService
    {
        Task<Response<string>> Get();

    }
}
