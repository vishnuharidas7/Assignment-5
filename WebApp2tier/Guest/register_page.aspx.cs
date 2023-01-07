using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication.Guest
{
    public partial class register_page : System.Web.UI.Page
    {
        Class1 obj = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnreg_Click(object sender, EventArgs e)
        {
            object ob = obj.exescalar("insert into tbl_login values('" + txtuser.Text + "','" + txtpass.Text + "', 'employee','Not Confirmed');select @@IDENTITY");
            obj.dbclose();

            if (ob.ToString() != null)
            {
   
                int i = obj.exenonquery("insert into tbl_employee values ('" + ob + "','" + txtname.Text + "','" + txtadd.Text + "','" + txtage.Text + "','" + Radiogen.SelectedValue + "');select @@IDENTITY");
                obj.dbclose();
                if (i == 1)
                {
                    // Response.Write("Sucessfully registered....!!!!");
                    Response.Write("<script>alert('Registered Successfully. Please wait till the Admin approve your registration to login...');</script>");
                    Server.Transfer("../Guest/Guest_Home.aspx");
                }
                else
                {
                    Response.Write("Failed due to some technical issue. Please try again later...!!");
                }
            }
        }
    }
}