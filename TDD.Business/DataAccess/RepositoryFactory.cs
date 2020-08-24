using TDD.Business.DataAccess.Interface;

namespace TDD.Business.DataAccess
{
    public class RepositoryFactory : IRepositoryFactory
    {
        //public IRepository<T> GetRepository<T>() where T : class, new()
        //{
        //    var repo = new Repository<T>();
        //    return repo;
        //}
        public IRepository<T> GetRepository<T>() where T : class, new()
        {
            var repo = new Repository<T>();
            return repo;

        }
    }
}
