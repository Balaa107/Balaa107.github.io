using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Question1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                DataBindView();
            }
        }
        protected void DataBindView()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=HP\SQLEXPRESS;Initial Catalog=Q1;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Registration";
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            DataSet ds = new DataSet();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void b1_Click(object sender, EventArgs e)
        {
            if(Validateform())
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=HP\SQLEXPRESS;Initial Catalog=Q1;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Registration(firstname,lastname,email,phone_no,location,username,password) values('" + t4.Text + "','" + t5.Text + "','" + t6.Text + "','" + t7.Text + "','" + t8.Text + "','" + t1.Text + "','" + t2.Text + "') ";
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                t1.Text = "";
                t2.Text = "";
                t3.Text = "";
                t4.Text = "";
                t5.Text = "";
                t6.Text = "";
                t7.Text = "";
                t8.Text = "";
                l1.Text = "Data Inserted Succefully";
                DataBindView();
            }
            
        }

        protected void b2_Click(object sender, EventArgs e)
        {
            t1.Text = "";
            t2.Text = "";
            t3.Text = "";
            t4.Text = "";
            t5.Text = "";
            t6.Text = "";
            t7.Text = "";
            t8.Text = "";
        }

        protected bool Validateform()
        {
            bool ret = true;
            int res,res1,res2;
            if(string.IsNullOrEmpty(t1.Text))
            {
                ret = false;
                l2.Text = "Username is Required";
            }
            else
            {
                l2.Text = "";
            }
            if (string.IsNullOrEmpty(t2.Text))
            {
                ret = false;
                l3.Text = "Password is Required";
            }
            else if((t2.Text).Length<5 && (t2.Text).Length>12)
            {
                ret = false;
                l3.Text = "Enter Minimum 5 and Maximum 12 length password";
            }
            else
            {
                l3.Text = "";
            }
            if (string.IsNullOrEmpty(t3.Text))
            {
                ret = false;
                l4.Text = "Confirmed Password is Required";
            }
            else if(t2.Text!=t3.Text)
            {
                ret = false;
                l4.Text = "Confirmed password does not match";
            }
            else
            {
                l4.Text = "";
            }
            if (string.IsNullOrEmpty(t4.Text))
            {
                ret = false;
                l5.Text = "First Name is Required";
            }
            else if(int.TryParse(t4.Text,out res))
            {
                l5.Text = "only enter characters";
            }
            else
            {
                l5.Text = "";
            }
            if (string.IsNullOrEmpty(t5.Text))
            {
                ret = false;
                l6.Text = "Last Name is Required";
            }
            else if (int.TryParse(t5.Text, out res1))
            {
                l6.Text = "only enter characters";
            }
            else
            {
                l6.Text = "";
            }
            if (string.IsNullOrEmpty(t6.Text))
            {
                ret = false;
                l7.Text = "Email is Required";
            }
            else if (!(Regex.IsMatch(t6.Text, "^[_a-z0-9-]+(\\.[_a-z0-9-]+)*@[a-z0-9-]+(\\.[a-z0-9-]+)+$")))
            {
                ret = false;
                l7.Text = "Email is Invalid";
            }
            else
            {
                l7.Text = "";
            }
            if (string.IsNullOrEmpty(t7.Text))
            {
                ret = false;
                l8.Text = "Phone No is Required";
            }
           
            else
            {
                l8.Text = "";
            }
            if (string.IsNullOrEmpty(t8.Text))
            {
                ret = false;
                l9.Text = "Location is Required";
            }
            else if (int.TryParse(t8.Text, out res2))
            {
                l9.Text = "only enter characters";
            }
            else
            {
                l9.Text = "";
            }
            return ret;
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName=="Edit")
            {
                int RowIndex = ((GridViewRow)((Button)e.CommandSource).NamingContainer).RowIndex;
                GridView1.EditIndex = RowIndex;
                DataBindView();
            }
            else if(e.CommandName=="Cancel")
            {
                GridView1.EditIndex = -1;
                DataBindView();
            }
            else if(e.CommandName=="Delete")
            {
                int RowIndex = ((GridViewRow)((Button)e.CommandSource).NamingContainer).RowIndex;
                int id = Convert.ToInt32((e.CommandArgument).ToString());
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=HP\SQLEXPRESS;Initial Catalog=Q1;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Registration where id='"+id+"'";
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                DataBindView();
            }
            else if(e.CommandName=="Update")
            {
                int RowIndex = ((GridViewRow)((Button)e.CommandSource).NamingContainer).RowIndex;
                int id=Convert.ToInt32((e.CommandArgument).ToString());
                string firstname = ((TextBox)GridView1.Rows[RowIndex].FindControl("TextBox1")).Text;
                string lastname= ((TextBox)GridView1.Rows[RowIndex].FindControl("TextBox2")).Text;
                string email= ((TextBox)GridView1.Rows[RowIndex].FindControl("TextBox3")).Text;
                string phone_no= ((TextBox)GridView1.Rows[RowIndex].FindControl("TextBox4")).Text;
                string location= ((TextBox)GridView1.Rows[RowIndex].FindControl("TextBox5")).Text;
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = @"Data Source=HP\SQLEXPRESS;Initial Catalog=Q1;Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "update Registration set firstname='" + firstname + "',lastname='" + lastname + "',email='" + email + "',location='"+location+"' where id='" + id + "'";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                GridView1.EditIndex = -1;
                DataBindView();

            }
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }
    }
}