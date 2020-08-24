using TDD.BusinessEntities;

namespace TDD.Business.Service.Interface
{
    public interface ISalaryService
    {
        //decimal CalculateGrossSalary();

        Salary AddSalary(Salary salary);

        Salary GetSalaryByEmployeeId(int id);

        bool IsSalaryEven(int sal);

    }
}
