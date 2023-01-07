using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication.Guest
{
    public partial class login_page : System.Web.UI.Page
    {
        Class1 obj = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnlogin_Click(object sender, EventArgs e)
        {
            DataTable dt = obj.exedatatable("select * from tbl_login where username='" + txtuser.Text + "' and password='" + txtusrpass.Text + "'");
            if (dt.Rows.Count > 0)
            {


                if (dt.Rows[0][3].ToString().Trim() == "admin")
                {
                    Response.Redirect("../Admin/Admin_home.aspx");
                }

                else if (dt.Rows[0][4].ToString() == "Confirmed" && dt.Rows[0][3].ToString() == "employee")
                {
                    Session["logID"] = dt.Rows[0][0];
                    Response.Redirect("../User/User_Home.aspx");
                }

                else if (dt.Rows[0][4].ToString() == "Not Confirmed" && dt.Rows[0][3].ToString() == "employee")
                {
                    Response.Write("Waiting for Comfirmation");
                }

                else if (dt.Rows[0][4].ToString() == "Blocked" && dt.Rows[0][3].ToString() == "employee")
                {
                    Response.Write("You are Blocked");
                }

            }
            else
            {
                Response.Write("username or password is incorrect");
            }
        }
    }
}