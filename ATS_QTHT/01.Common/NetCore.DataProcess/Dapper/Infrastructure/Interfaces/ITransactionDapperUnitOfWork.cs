namespace NetCore.DataProcess.Infrastructure.Interfaces
{
    public interface ITransactionDapperUnitOfWork : IDisposable
    {
        IDapperReposity GetRepository();
        bool Save();
    }
}
