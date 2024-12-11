using NetCore.DataProcess.Infrastructure.Interfaces;
using System;
using System.Data;

namespace NetCore.DataProcess.Infrastructure.Impl
{
    public class DapperUnitOfWork : IDapperUnitOfWork
    {
        private readonly IDbConnection _readConnection;
        private readonly IDbConnection _writeConnection;
        private bool _disposed;
        /// <summary>
        /// DapperUnitOfWork
        /// </summary>
        /// <param name="dbConnectionFactory"></param>
        public DapperUnitOfWork(IDbConnectionFactory dbConnectionFactory)
        {
            _readConnection = dbConnectionFactory.CreateDbConnection(DatabaseConnectionName.ReadConnectionString);
            _writeConnection = dbConnectionFactory.CreateDbConnection(DatabaseConnectionName.WriteConnectionString);
            _readConnection.Open();
            _writeConnection.Open();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        /// <summary>
        /// Dispose
        /// </summary>
        /// <param name="disposing"></param>
        public virtual void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing)
            {

                if (_readConnection != null)
                {
                    _readConnection.Dispose();
                }

                if (_writeConnection != null)
                {
                    _writeConnection.Dispose();
                }
            }
            _disposed = true;
        }
        /// <summary>
        /// GetRepository
        /// </summary>
        /// <returns></returns>
        public IDapperReposity GetRepository()
        {
            return new DapperReposity(_readConnection, _writeConnection);
        }
    }
}
