using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    /// <summary>
    /// Interface to define objects
    /// </summary>
     public interface IFactoryEmployee
    {
        IEmployee CreateEmployee();

    }
    /// <summary>
    /// Class to create the respective  Hourly object
    /// </summary>
    public class HourFactory : IFactoryEmployee
    {
        public IEmployee CreateEmployee()
        {
            return new  EmployeeHourly();
        }
    }
    /// <summary>
    /// Class to create the respective  Monthly object
    /// </summary>
    public class MonthFactory : IFactoryEmployee
    {
        public IEmployee CreateEmployee()
        {
            return new EmployeeMontly();
        }
    }


}
