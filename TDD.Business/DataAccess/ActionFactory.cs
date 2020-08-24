using TDD.Business.DataAccess.Interface;
using TDD.Business.Service;
using TDD.Business.Service.Interface;

namespace TDD.Business.DataAccess
{
    public class ActionFactory : IActionFactory
    {
        private IEmployeeService _employeeService;

        private AddressService _addressService;

        private SalaryService _salaryService;

        public IEmployeeService EmployeeService => _employeeService ?? (_employeeService = new EmployeeService());

        public IAddressService AddressService => _addressService ?? (_addressService = new AddressService());

        public ISalaryService SalaryService => _salaryService ?? (_salaryService = new SalaryService());
    }
}
