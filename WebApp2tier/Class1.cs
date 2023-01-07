using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public class Class1
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public Class1()
        {
            con.ConnectionString = "Data Source=NTP-LAP-927\\SQL_SERVER;Initial Catalog=empuser;Integrated Security=True;Pooling=False";
            cmd.Connection = con;
        }

        public SqlConnection Getcon()

        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void dbclose()
        {
            con.Close();

        }

        public DataSet exedataset(String sql)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }


        public DataTable exedatatable(string sql)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int exenonquery(String Sql)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Sql;
            int i = cmd.ExecuteNonQuery();
            return i;
        }

        public object exescalar(String Sql)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Sql;
            object ex = cmd.ExecuteScalar();
            return ex;
        }
        public void fillddl(String sql,DropDownList ddl,String txt,String val)
        {
            ddl.DataTextField = txt;
            ddl.DataValueField = val;
            ddl.DataSource = exedataset(sql);
            ddl.DataBind();
        }
    }
}