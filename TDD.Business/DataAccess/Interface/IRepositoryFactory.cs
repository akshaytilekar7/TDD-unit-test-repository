namespace TDD.Business.DataAccess.Interface
{
    public interface IRepositoryFactory
    {
        IRepository<T> GetRepository<T>() where T : class, new();
    }
}
