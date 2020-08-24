using System.Collections.Generic;

namespace TDD.Business.DataAccess.Interface

{
    public interface IRepository<T> where T : class, new()
    {
        T Create(T entity);

        List<T> GetAllData();

        T GetById(int id);

        T Update(T entity);

        bool Delete(int id);
    }
}
