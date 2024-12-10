using Microsoft.AspNetCore.Http.Features.Authentication;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using NetCore.Core.Utils;
using NetCore.DataProcess.EntitiFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace NetCore.DataProcess
{
    public static class ProjectServiceCollectionExtensions
    {
        public static IServiceCollection RegisterDataContextServiceComponents(this IServiceCollection services, IConfiguration configuration)
        {
            #region Config database
            var databaseType = AppSettings.Instance.GetEnviromentVariable("ConnectionString:DbType");
            var connectionString = AppSettings.Instance.GetEnviromentVariable("ConnectionString:" + databaseType);

            switch (databaseType)
            {
                case "MySqlPomeloDatabase":
                    services.AddDbContext<LOYALTYContext>(x => x.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
                    break;

                case "MSSQLDatabase":
                    services.AddDbContext<LOYALTYContext>(x => x.UseSqlServer(connectionString));
                    break;

                case "Sqlite":
                    services.AddDbContext<LOYALTYContext>(x => x.UseSqlite(connectionString));
                    break;
                case "PostgreSQLDatabase":
                    services.AddDbContext<LOYALTYContext>(x => x.UseNpgsql(connectionString));
                    break;
                case "OracleDatabase":
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
