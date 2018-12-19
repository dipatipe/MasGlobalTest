using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
   public abstract class SuperEmployee
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
        public abstract string ContractTypeName { get; set; }
        public abstract int Roleid { get; set; }
        public abstract string RoleName { get; set; }
        public abstract string RoleDescription { get; set; }
        public abstract double HourlySalary { get; set; }
        public abstract double MonthlySalary { get; set; }
        public abstract double AnualSalary { get; set; }

        public abstract IEmployee FactoryMethod();

        public abstract double GetAnnualSalary();
        public abstract  List<Employee> GetEmployees();
        public abstract List<Employee> getEmployeebyID(int EmployeeID);

    }
}
