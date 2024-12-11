using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCore.Core.Utils;
using Microsoft.EntityFrameworkCore;
using static NetCore.Core.Utils.Constant;

namespace NetCore.DataProcess.EntitiFramework
{
    public static class ProjectServiceCollectionExtensions
    {
        public static IServiceCollection RegisterDataContextServiceComponents(this IServiceCollection services, IConfiguration configuration)
        {
            #region Config database
            var databaseType = AppSettings.Instance.GetEnviromentVariable("ConnectionString:DbType");
            var connectionString = AppSettings.Instance.GetEnviromentVariable($"ConnectionString:{databaseType}");
            switch (databaseType)
            {
                case DatabaseType.MYSQL:
                    services.AddDbContext<LOYALTYContext>(x => x.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
                    break;
                case DatabaseType.MSSQL:
                    services.AddDbContext<LOYALTYContext>(x => x.UseSqlServer(connectionString));
                    break;
                case DatabaseType.SQLITE:
                    services.AddDbContext<LOYALTYContext>(x => x.UseSqlite(connectionString));
                    break;
                case DatabaseType.POSTGRESQL:
                    services.AddDbContext<LOYALTYContext>(x => x.UseNpgsql(connectionString));
                    break;
                case DatabaseType.ORACLE:
                    services.AddDbContext<LOYALTYContext>(x => x.UseOracle(connectionString));
                    break;
                default:
                    services.AddDbContext<LOYALTYContext>(x => x.UseSqlServer(connectionString));
                    break;
            }

            #endregion Config database

            return services;
        }

    }
}
