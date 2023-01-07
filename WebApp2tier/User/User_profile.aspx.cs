using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication.User
{
    public partial class User_Home : System.Web.UI.Page
    {
        Class1 obj = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int userid = Convert.ToInt32(Session["logID"]);
                DataTable dt = obj.exedatatable("select r.*,l.* from  tbl_login r inner join tbl_employee l on r.Id = l.Id where r.Id='" + userid + "'");
                if (dt.Rows.Count > 0)
                {
                    lblusr.Text = dt.Rows[0]["username"].ToString();
                    lblname.Text = dt.Rows[0]["name"].ToString();
                    lblemail.Text = dt.Rows[0]["Email"].ToString();
                    lblgen.Text = dt.Rows[0]["gender"].ToString();
                    lblage.Text = dt.Rows[0]["age"].ToString();

                }
            }
        }

      

    }
}