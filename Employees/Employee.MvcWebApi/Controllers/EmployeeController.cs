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
        [HttpGet]
        public List<Employees.Employee> GetEmployees()
        {

            Employees.Employee objEmployee = new Employees.Employee();
            List<Employees.Employee> lstEmployees = objEmployee.GetEmployees();
            return lstEmployees;
        }

        [HttpGet]
        public Employees.Employee GetEmployeebyID(int Id)
        {
            Employees.Employee objEmployee = new Employees.Employee();
            Employees.Employee objEmployeebyID = objEmployee.getEmployeebyID(Id).FirstOrDefault();
            return objEmployeebyID;
        }






    }
}
