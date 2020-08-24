using System.Collections.Generic;
using TDD.BusinessEntities;

namespace TDD.Business.Service.Interface
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAllEmployees();

    }
}
