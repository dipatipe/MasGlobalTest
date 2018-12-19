using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Employee.MvcWebApi.Controllers
{
    public class EmployeeController : ApiController
    {
       
        /// <summary>
        /// Get all employees
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Employees.EmployeeDTO> GetEmployees()
        {

            Employees.EmployeeHourly objEmployee = new Employees.EmployeeHourly();
            List<Employees.EmployeeDTO> lstEmployees = objEmployee.GetEmployees();
            return lstEmployees;
        }
        /// <summary>
        /// Get employee by ID
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        public Employees.EmployeeDTO GetEmployeebyID(int Id)
        {
            Employees.EmployeeHourly objEmployee = new Employees.EmployeeHourly();
            Employees.EmployeeDTO objEmployeeDTO = objEmployee.getEmployeebyID(Id);
            return objEmployeeDTO;
        }





    }
}
