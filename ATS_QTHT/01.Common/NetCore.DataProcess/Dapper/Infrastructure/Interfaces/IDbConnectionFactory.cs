using System.Data;

namespace NetCore.DataProcess.Infrastructure.Interfaces
{
    public interface IDbConnectionFactory
    {
        IDbConnection CreateDbConnection(DatabaseConnectionName connectionName);

    }
}
