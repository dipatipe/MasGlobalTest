using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employees.Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if(Page.IsPostBack==false)
            {

            }
        }

        protected void btnGetEmployee_Click(object sender, EventArgs e)
        {
            //Employees objEmployee = new Employee();

            //int result=0;
            //if (int.TryParse(txtID.Text, out result) == false)
            //    Response.Write("Please insert a number!");

            //if (txtID.Text=="")
            //{
                
            //    gvEmployee.DataSource = objEmployee.GetEmployees();
            //    gvEmployee.DataBind();
            //}
            //else
            //{
            //    gvEmployee.DataSource = objEmployee.getEmployeebyID(Convert.ToInt32(txtID.Text));
            //    gvEmployee.DataBind();
            //}
        }
    }
}