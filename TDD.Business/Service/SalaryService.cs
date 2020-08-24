using System;
using System.Linq;
using TDD.Business.DataAccess;
using TDD.Business.DataAccess.Interface;
using TDD.Business.Helper;
using TDD.Business.Service.Interface;
using TDD.BusinessEntities;

namespace TDD.Business.Service
{
    public class SalaryService : ISalaryService
    {

        private readonly IActionFactory _actionFactory;
        private readonly IRepositoryFactory _repositoryFactory;
        private readonly HelperSer _helperSer;
        public SalaryService() : this(new ActionFactory(), new RepositoryFactory(), new HelperSer()) { }

        public SalaryService(IActionFactory actionFactory, IRepositoryFactory repositoryFactory, HelperSer helperSer)
        {
            _actionFactory = actionFactory;
            _repositoryFactory = repositoryFactory;
            _helperSer = helperSer;
        }

        public Salary GetSalaryByEmployeeId(int id)
        {
            var employee = _actionFactory.EmployeeService.GetAllEmployees().FirstOrDefault(x => x.Id == id);
            if (employee == null)
                throw new Exception(Constants.EmployeeNotFound);

            var salary = _repositoryFactory.GetRepository<Salary>().GetById(employee.SalaryId);
            salary.GrossSalary = CalculateGrossSalary(salary);
            salary.IsEven = IsSalaryEven(Convert.ToInt32(salary.GrossSalary));
            return salary;
        }

        public Salary AddSalary(Salary salary)
        {
            salary = _repositoryFactory.GetRepository<Salary>().Create(salary);
            return salary;
        }

        private decimal CalculateGrossSalary(Salary salary)
        {
            return salary.Basic + salary.Incentives + salary.Bonus;
        }

        public bool IsSalaryEven(int sal)
        {
            return _helperSer.IsEven(Convert.ToInt32(sal));
        }
    }
}
