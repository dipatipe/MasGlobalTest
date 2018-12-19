using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace Employees
{
    public class Employee
    {
        //variables
        private double dblAnualSalary=0;

        //Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContractTypeName { get; set; }
        public int Roleid { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public double HourlySalary { get; set; }
        public double MonthlySalary { get; set; }
        public double AnualSalary
        {
            get
            {
                dblAnualSalary = GetAnnualSalary();
                return dblAnualSalary;
            }
            set { dblAnualSalary = value; }
        }

        //Methods
        /// <summary>
        ///     Get Annual salary base on ContractTypeName
        /// </summary>
        /// <returns></returns>
        private   double  GetAnnualSalary()
        {
            if (ContractTypeName != "HourlySalaryEmployee")
                return MonthlySalary * 12;
            else
                return 120 * HourlySalary * 12;
        }

        /// <summary>
        ///    Get All employees from API
        /// </summary>
        /// <returns></returns>
        public  List<Employee> GetEmployees()
        {

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(ConfigurationManager.AppSettings["ServiceUrl"]);
            request.Method = "GET";
            String strEmployees = String.Empty;
            List<Employee> lstemployees;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                Stream dataStream = response.GetResponseStream();
                StreamReader Sreader = new StreamReader(dataStream);
                strEmployees = Sreader.ReadToEnd();             
                lstemployees = JsonConvert.DeserializeObject<List<Employee>>(strEmployees);              

                Sreader.Close();
                dataStream.Close();
            }           



            return lstemployees;
        }

       /// <summary>
       /// Get and employee by ID
       /// </summary>
       /// <param name="EmployeeID"></param>
       /// <returns></returns>

        public  List<Employee> getEmployeebyID( int EmployeeID)
        {

            Employee objEmployee = GetEmployees().Find(p => p.Id == EmployeeID);
            List<Employee> lstEmployees = new List<Employee>();
            lstEmployees.Add(objEmployee);

            return lstEmployees;
        }

       
    }
}
