using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication;

namespace WebApp2tier.Admin
{
    public partial class View_confirmed_users : System.Web.UI.Page
    {
        Class1 obj = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = obj.exedatatable("select * from tbl_login where role='employee' AND status='Confirmed'");
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Admin/Admin_confirm.aspx");
        }
    }
}