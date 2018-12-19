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
    /// <summary>
    /// Class for employees with Monthly Salary
    /// </summary>
    public class EmployeeMontly : IEmployee

    {
        private double dblAnualSalary = 0;


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

        public double GetAnnualSalary()
        {            
                return 12 * MonthlySalary ;

        }
        /// <summary>
        ///    Get All employees from API
        /// </summary>
        /// <returns></returns>
        public List<EmployeeDTO> GetEmployees()
        {

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(ConfigurationManager.AppSettings["ServiceUrl"]);
            request.Method = "GET";
            String strEmployees = String.Empty;
            List<EmployeeDTO> lstemployees;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                Stream dataStream = response.GetResponseStream();
                StreamReader Sreader = new StreamReader(dataStream);
                strEmployees = Sreader.ReadToEnd();
                lstemployees = JsonConvert.DeserializeObject<List<EmployeeDTO>>(strEmployees);

                foreach (var dato in lstemployees)
                {
                    if (dato.ContractTypeName.Equals("HourlySalaryEmployee"))
                    {
                        IFactoryEmployee factory = new HourFactory();
                        var objHourly = factory.CreateEmployee();
                        objHourly.HourlySalary = dato.HourlySalary;
                        dato.AnualSalary = objHourly.AnualSalary;
                    }
                    else
                    {
                        IFactoryEmployee factory = new MonthFactory();
                        var objMonth = factory.CreateEmployee();
                        objMonth.MonthlySalary = dato.MonthlySalary;
                        dato.AnualSalary = objMonth.AnualSalary;
                    }
                }

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
        public EmployeeDTO getEmployeebyID(int EmployeeID)
        {

            EmployeeDTO objEmployee = GetEmployees().Find(p => p.Id == EmployeeID);

            if (objEmployee != null)
            {
                if (objEmployee.ContractTypeName.Equals("HourlySalaryEmployee"))
                {
                    IFactoryEmployee factory = new HourFactory();
                    var objHourly = factory.CreateEmployee();
                    objHourly.HourlySalary = objEmployee.HourlySalary;
                    objEmployee.AnualSalary = objHourly.AnualSalary;
                }
                else
                {
                    IFactoryEmployee factory = new MonthFactory();
                    var objMonth = factory.CreateEmployee();
                    objMonth.MonthlySalary = objEmployee.MonthlySalary;
                    objEmployee.AnualSalary = objMonth.AnualSalary;
                }
            }

            return objEmployee;
        }




    }
}
