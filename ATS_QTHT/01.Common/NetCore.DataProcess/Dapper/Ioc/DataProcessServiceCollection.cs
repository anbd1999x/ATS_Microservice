using Microsoft.Extensions.DependencyInjection;
using NetCore.Core.Utils;
using NetCore.DataProcess.Infrastructure.Impl;
using NetCore.DataProcess.Infrastructure.Interfaces;

namespace NetCore.DataProcess.Ioc
{
    public static class DataProcessServiceCollection
    {
        /// <summary>
        /// RegisterDapperServiceComponents
        /// </summary>
        /// <param name="services"></param>
        public static IServiceCollection RegisterDapperServiceComponents(this IServiceCollection services)
        {
            #region Config database
            var databaseType = AppSettings.Instance.GetEnviromentVariable("ConnectionString:DbType");
            var connectionString = AppSettings.Instance.GetEnviromentVariable($"ConnectionString:{databaseType}");
            var connectionDict = new Dictionary<DatabaseConnectionName, string>
            {
                { DatabaseConnectionName.ReadConnectionString, connectionString },
                { DatabaseConnectionName.WriteConnectionString,connectionString }
            };

            services.AddSingleton<IDictionary<DatabaseConnectionName, string>>(connectionDict);
            services.AddTransient<IDbConnectionFactory, DbConnectionFactory>();
            services.AddScoped<IDapperUnitOfWork, DapperUnitOfWork>();
            services.AddScoped<ITransactionDapperUnitOfWork, TransactionDapperUnitOfWork>();

            return services;
            #endregion Config database

        }
    }
}