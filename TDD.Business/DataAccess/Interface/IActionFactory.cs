﻿using TDD.Business.Service.Interface;

namespace TDD.Business.DataAccess.Interface
{
    public interface IActionFactory
    {
        IEmployeeService EmployeeService { get; }

        IAddressService AddressService { get; }

        ISalaryService SalaryService { get; }
    }
}
