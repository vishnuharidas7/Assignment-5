using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication.Admin
{
    public partial class Admin_confirm : System.Web.UI.Page
    {
        Class1 obj = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = obj.exedatatable("select * from tbl_login where role='employee' AND status='Not confirmed'");
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int ID = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            int i = obj.exenonquery("update tbl_login set status = 'Confirmed' where Id='" + ID + "'");
            if (i == 1)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('" + "Confirmed Successfully" + "');", true);

            }
            GridView1.DataSource = obj.exedatatable("select * from tbl_login where role= 'employee' AND status='Not Confirmed'");
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = obj.exedatatable("select * from tbl_login where role='employee' AND status='Not Confirmed'");
            GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            int ID = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            int i = obj.exenonquery("update tbl_login set status = 'Blocked' where Id='" + ID + "'");
            if (i == 1)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('" + "Canceled" + "');", true);

            }
            GridView1.DataSource = obj.exedatatable("select * from tbl_login where role='employee' AND status='Not Confirmed'");
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int ID = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            int i = obj.exenonquery("update tbl_login set status = 'Confirmed' where Id='" + ID + "'");
            if (i == 1)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('" + "Confirmed Successfully" + "');", true);
                GridView1.DataSource = obj.exedatatable("select * from tbl_login where role='employee' AND status='Not Confirmed'");
                GridView1.DataBind();
            }
            GridView1.DataSource = obj.exedatatable("select * from tbl_login where role='employee' AND status='Not Confirmed'");
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Admin/View_confirmed_users.aspx");
        }
    }
}