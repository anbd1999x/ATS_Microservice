using Dapper;
using Microsoft.Data.SqlClient;
using Npgsql;
using Oracle.ManagedDataAccess.Client;
using NetCore.Core.Utils;
using NetCore.DataProcess.Infrastructure.Interfaces;
using System.Data;
using static NetCore.DataProcess.Helper.DapperMapping;
using MySqlConnector;

namespace NetCore.DataProcess.Infrastructure.Impl
{
    public class DbConnectionFactory : IDbConnectionFactory
    {
        private readonly IDictionary<DatabaseConnectionName, string> _connectionDict;
        /// <summary>
        /// DbConnectionFactory
        /// </summary>
        /// <param name="connectionDict"></param>
        public DbConnectionFactory(IDictionary<DatabaseConnectionName, string> connectionDict)
        {
            _connectionDict = connectionDict;
        }
        /// <summary>
        /// CreateDbConnection
        /// </summary>
        /// <param name="connectionName"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public IDbConnection CreateDbConnection(DatabaseConnectionName connectionName)
        {
            string connectionString = null;
            var dbUsing = AppSettings.Instance.GetString("ConnectionString:DbType");
            if (dbUsing == Constant.DatabaseType.MYSQL)
            {
                if (_connectionDict.TryGetValue(connectionName, out connectionString))
                {
                    return new MySqlConnection(connectionString);
                }
            }
            if (dbUsing == Constant.DatabaseType.MSSQL)
            {
                if (_connectionDict.TryGetValue(connectionName, out connectionString))
                {
                    return new SqlConnection(connectionString);
                }
            }
            else if (dbUsing == Constant.DatabaseType.POSTGRESQL)
            {
                if (_connectionDict.TryGetValue(connectionName, out connectionString))
                {
                    return new NpgsqlConnection(connectionString);
                }
            }
            else if (dbUsing == Constant.DatabaseType.ORACLE)
            {
                if (_connectionDict.TryGetValue(connectionName, out connectionString))
                {
                    // if using oracle mapping convert byte[] to guid
                    SqlMapper.AddTypeHandler(new ByteArrayToGuidHandler());
                    SqlMapper.RemoveTypeMap(typeof(bool));
                    SqlMapper.AddTypeHandler(new BooleanToOracleNumberTypeHandler());
                    return new OracleConnection(connectionString);
                }
            }
            throw new ArgumentNullException();
        }
    }
}
