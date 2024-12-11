using NetCore.DataProcess.Infrastructure.Interfaces;
using System.Data;

namespace NetCore.DataProcess.Infrastructure.Impl
{

    public class TransactionDapperUnitOfWork : ITransactionDapperUnitOfWork
    {
        private readonly IDbConnection _readConnection;
        private readonly IDbConnection _writeConnection;
        protected IDbTransaction _transaction;
        private bool _disposed;
        /// <summary>
        /// TransactionDapperUnitOfWork
        /// </summary>
        /// <param name="dbConnectionFactory"></param>
        public TransactionDapperUnitOfWork(IDbConnectionFactory dbConnectionFactory)
        {
            _readConnection = dbConnectionFactory.CreateDbConnection(DatabaseConnectionName.ReadConnectionString);
            _writeConnection = dbConnectionFactory.CreateDbConnection(DatabaseConnectionName.WriteConnectionString);
            _readConnection.Open();
            _writeConnection.Open();
            _transaction = _writeConnection.BeginTransaction();
        }
        /// <summary>
        /// Save
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            bool result = false;
            try
            {
                _transaction.Commit();
                result = true;
            }
            catch
            {
                _transaction.Rollback();
            }
            finally
            {
                _transaction.Dispose();
                _transaction = _writeConnection.BeginTransaction();
            }
            return result;
        }
        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        /// <summary>
        /// Close
        /// </summary>
        public void Close()
        {
            Dispose(true);
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
                if (_transaction != null)
                {
                    _transaction.Dispose();
                }

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
            return new DapperReposity(_transaction, _readConnection, _writeConnection);
        }

    }
}
