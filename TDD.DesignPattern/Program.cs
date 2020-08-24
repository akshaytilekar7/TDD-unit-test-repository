using System;
using TDD.Business.DataAccess;
using TDD.Business.Service;
using TDD.BusinessEntities;

namespace TDD
{
    class Program
    {
        public static void Main()
        {
            var actionFactory = new ActionFactory();
            var repositoryFactory = new RepositoryFactory();
            EmployeeService employeeService = new EmployeeService(actionFactory, repositoryFactory);
            var res = employeeService.AddEmployees(new Employee(), new Address());

            Console.ReadKey();
        }
    }
}
