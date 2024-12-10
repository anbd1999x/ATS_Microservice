namespace ATS_QTHT_API.Ioc
{
    public static class CustomServiceCollection
    {
        public static IServiceCollection RegisterAddCorsComponents(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .WithExposedHeaders("*"));
            });
            return services;
        }
    }
}
