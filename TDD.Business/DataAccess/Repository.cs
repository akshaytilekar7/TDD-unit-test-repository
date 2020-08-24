using System.Collections.Generic;
using TDD.Business.DataAccess.Interface;

namespace TDD.Business.DataAccess
{
    public class Repository<T> : IRepository<T> where T : class, new()//EntityAction<T>,
    {
        public T Create(T entity)
        {
            var tableName = entity.GetType().Name;
            var propertiesNames = entity.GetType().GetProperties(); // all variables
            var propertyValues = entity.GetType().GetProperty(propertiesNames[0].Name); // var values
            //actual DB call 
            return entity;
        }

        public T GetById(int id)
        {
            //actual DB call 
            return new T();
        }

        public List<T> GetAllData()
        {
            //actual DB call 
            return new List<T>();
        }

        public T Update(T entity)
        {
            //actual DB call 
            return entity;
        }

        public bool Delete(int id)
        {
            //actual DB call 
            return true;
        }
    }
}
