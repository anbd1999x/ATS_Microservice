
using ATS_QTHT_Service.AwsS3.Logic.ProcessAwsS3;
using NetCore.Core.Caching.Ioc;
using NetCore.Core.Utils;
using System.Net.Http.Headers;

namespace ATS_QTHT_API.Ioc
{
    public static class ApiServiceCollection
    {
        public static void AddApiServices(this IServiceCollection services, IConfiguration configuration)
        {
            AppSettings.Instance.SetConfiguration(configuration);
            services.AddCachingProcessServices();

            services.AddHttpClient<IDbProcessAwsS3HttpService, DbProcessAwsS3HttpService>(client =>
            {
                client.BaseAddress = new Uri(AppSettings.Instance.GetEnviromentVariable(Constant.HttpServiceUrl.AwS3));
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            });

            services.AddHttpContextAccessor();

        }
    }
}
