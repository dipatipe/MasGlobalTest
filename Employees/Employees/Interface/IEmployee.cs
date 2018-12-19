using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    /// <summary>
    /// Definition of employee with his properties and his methods
    /// </summary>
    public interface IEmployee
    {
         int Id { get; set; }
         string Name { get; set; }
         string ContractTypeName { get; set; }
         int Roleid { get; set; }
         string RoleName { get; set; }
         string RoleDescription { get; set; }
         double HourlySalary { get; set; }
         double MonthlySalary { get; set; }
         double AnualSalary { get; set; }

        double GetAnnualSalary();

        List<EmployeeDTO> GetEmployees();
        EmployeeDTO getEmployeebyID(int EmployeeID);
    }
}
