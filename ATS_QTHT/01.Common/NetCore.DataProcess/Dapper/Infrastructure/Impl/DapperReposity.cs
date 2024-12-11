using Dapper;
using NetCore.DataProcess.Infrastructure.Interfaces;
using System.Data;

namespace NetCore.DataProcess.Infrastructure.Impl
{
    public class DapperReposity : IDapperReposity
    {
        private readonly IDbTransaction _transaction;
        private readonly IDbConnection _readConnection;
        private readonly IDbConnection _writeConnection;
        /// <summary>
        /// DapperReposity
        /// </summary>
        /// <param name="readConnection"></param>
        /// <param name="writeConnection"></param>
        public DapperReposity(IDbConnection readConnection, IDbConnection writeConnection)
        {
            _readConnection = readConnection;
            _writeConnection = writeConnection;
        }
        /// <summary>
        /// Contructer này chỉ khởi tạo write connection vì transaction chỉ dùng cho các hàm execute
        /// </summary>
        /// <param name="transaction"></param>
        public DapperReposity(IDbTransaction transaction, IDbConnection readConnection, IDbConnection writeConnection)
        {
            _transaction = transaction;
            _writeConnection = writeConnection;
            _readConnection = readConnection;
        }
        /// <summary>
        /// Execute
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="trans"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public int Execute(string sql, object param = null, IDbTransaction trans = null, CommandType? commandType = null)
        {
            if (commandType == null)
            {
                commandType = CommandType.Text;
            }
            if (trans == null)
            {
                trans = _transaction;
            }
            return _writeConnection.Execute(sql, param, transaction: trans, commandType: commandType);
        }
        /// <summary>
        /// ExecuteAsync
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="trans"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public async Task<int> ExecuteAsync(string sql, object param = null, IDbTransaction trans = null, CommandType? commandType = null)
        {
            if (commandType == null)
            {
                commandType = CommandType.Text;
            }
            if (trans == null)
            {
                trans = _transaction;
            }
            return await _writeConnection.ExecuteAsync(sql, param, transaction: trans, commandType: commandType);
        }
        /// <summary>
        /// ExecuteScalar
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="trans"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>

        public T ExecuteScalar<T>(string sql, object param = null, IDbTransaction trans = null, CommandType? commandType = null)
        {
            if (commandType == null)
            {
                commandType = CommandType.Text;
            }
            if (trans == null)
            {
                trans = _transaction;
            }
            return _writeConnection.ExecuteScalar<T>(sql, param, transaction: trans, commandType: commandType);
        }
        /// <summary>
        /// ExecuteScalarAsync
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="trans"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public async Task<T> ExecuteScalarAsync<T>(string sql, object param = null, IDbTransaction trans = null, CommandType? commandType = null)
        {
            if (commandType == null)
            {
                commandType = CommandType.Text;
            }
            if (trans == null)
            {
                trans = _transaction;
            }
            var t = await _writeConnection.ExecuteScalarAsync<T>(sql, param, trans, commandType: commandType);
            return t;
        }
        /// <summary>
        /// Query
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="trans"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public IEnumerable<T> Query<T>(string sql, object param = null, IDbTransaction trans = null, CommandType? commandType = null)
        {
            if (commandType == null)
            {
                commandType = CommandType.Text;
            }
            return _readConnection.Query<T>(sql, param, null, commandType: commandType);
        }
        /// <summary>
        /// QueryMultiple
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <param name="trans"></param>
        /// <param name="commandType"></param>
        /// <param name="readerFuncs"></param>
        /// <returns></returns>
        public List<object> QueryMultiple(string sql, object parameters, IDbTransaction trans = null, CommandType? commandType = default, params Func<SqlMapper.GridReader, object>[] readerFuncs)
        {
            var returnResults = new List<object>();
            var gridReader = _readConnection.QueryMultiple(sql, parameters, null, commandTimeout: 10000, commandType: commandType);

            foreach (var readerFunc in readerFuncs)
            {
                var obj = readerFunc(gridReader);
                returnResults.Add(obj);
            }
            return returnResults;
        }
        /// <summary>
        /// QueryMultipleAsync
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <param name="trans"></param>
        /// <param name="commandType"></param>
        /// <param name="readerFuncs"></param>
        /// <returns></returns>
        public async Task<List<object>> QueryMultipleAsync(string sql, object parameters, IDbTransaction trans = null, CommandType? commandType = default, params Func<SqlMapper.GridReader, object>[] readerFuncs)
        {
            var returnResults = new List<object>();
            var gridReader = await _readConnection.QueryMultipleAsync(sql, parameters, null, commandTimeout: 10000, commandType: commandType);

            foreach (var readerFunc in readerFuncs)
            {
                var obj = readerFunc(gridReader);
                returnResults.Add(obj);
            }
            return returnResults;
        }
        /// <summary>
        /// QueryAsync
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="trans"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public async Task<IEnumerable<T>> QueryAsync<T>(string sql, object param = null, IDbTransaction trans = null, CommandType? commandType = null)
        {
            if (commandType == null)
            {
                commandType = CommandType.Text;
            }
            return await _readConnection.QueryAsync<T>(sql, param, null, commandType: commandType);
        }
        /// <summary>
        /// QuerySingleOrDefault
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="trans"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public T QuerySingleOrDefault<T>(string sql, object param = null, IDbTransaction trans = null, CommandType? commandType = null)
        {
            if (commandType == null)
            {
                commandType = CommandType.Text;
            }
            return _readConnection.QuerySingleOrDefault<T>(sql, param, transaction: null, commandType: commandType);
        }
        /// <summary>
        /// QuerySingleOrDefaultAsync
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="trans"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public async Task<T> QuerySingleOrDefaultAsync<T>(string sql, object param = null, IDbTransaction trans = null, CommandType? commandType = null)
        {
            if (commandType == null)
            {
                commandType = CommandType.Text;
            }
            return await _readConnection.QuerySingleOrDefaultAsync<T>(sql, param, null, commandType: commandType);
        }
    }
}
