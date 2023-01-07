using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Assignment5
{
    public class employee
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public employee()
        {
            con.ConnectionString = "Data Source=NTP-LAP-927\\SQL_SERVER;Initial Catalog=Employee;Integrated Security=True;Pooling=False";
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
        public int Insert(String Sql)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Sql;
            int i = cmd.ExecuteNonQuery();
            return i;
        }

        public DataTable GetDetails(string sql)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int Updateemp(String Sql)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Sql;
            int i = cmd.ExecuteNonQuery();
            return i;
        }
    }
}