namespace NetCore.DataProcess.Infrastructure.Interfaces
{
    public interface IDapperUnitOfWork : IDisposable
    {
        IDapperReposity GetRepository();
    }
}
