using System.Data;

namespace NetCore.DataProcess.Infrastructure.Interfaces
{
    public interface IDapperReposity
    {
        //Read
        T QuerySingleOrDefault<T>(string sql, object param = null, IDbTransaction trans = null, CommandType? commandType = null);
        List<object> QueryMultiple(string sql, object parameters, IDbTransaction trans = null, CommandType? commandType = default, params Func<Dapper.SqlMapper.GridReader, object>[] readerFuncs);
        IEnumerable<T> Query<T>(string sql, object param = null, IDbTransaction trans = null, CommandType? commandType = null);
        Task<T> QuerySingleOrDefaultAsync<T>(string sql, object param = null, IDbTransaction trans = null, CommandType? commandType = null);
        Task<List<object>> QueryMultipleAsync(string sql, object parameters, IDbTransaction trans = null, CommandType? commandType = default, params Func<Dapper.SqlMapper.GridReader, object>[] readerFuncs);
        Task<IEnumerable<T>> QueryAsync<T>(string sql, object param = null, IDbTransaction trans = null, CommandType? commandType = null);

        //Write
        Task<T> ExecuteScalarAsync<T>(string sql, object param = null, IDbTransaction trans = null, CommandType? commandType = null);
        Task<int> ExecuteAsync(string sql, object param = null, IDbTransaction trans = null, CommandType? commandType = null);
        T ExecuteScalar<T>(string sql, object param = null, IDbTransaction trans = null, CommandType? commandType = null);
        int Execute(string sql, object param = null, IDbTransaction trans = null, CommandType? commandType = null);
    }
}
