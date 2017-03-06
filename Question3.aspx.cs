using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Question3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=HP\SQLEXPRESS;Initial Catalog=Q3;Integrated Security=True";
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Dname,Count(Employee.EmpNo) as NumberofEmployee from Department join Employee on Department.DeptNo = Employee.DeptNo Group by Department.DeptNo,Department.Dname ";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = cmd;
            ad.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            conn.Close();

            
        }
    }
}