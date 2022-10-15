using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Connect_To_Database
{
    public partial class signup : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into signup_tbl values(@fname,@lname,@gender,@age,@username,@email,@password)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@fname", fTextBox1.Text);
            cmd.Parameters.AddWithValue("@lname", lTextBox2.Text);
            cmd.Parameters.AddWithValue("@gender", DropDownList1.SelectedItem.Value);
            cmd.Parameters.AddWithValue("@age", aTextBox3.Text);
            cmd.Parameters.AddWithValue("@username", uTextBox4.Text);
            cmd.Parameters.AddWithValue("@email", eTextBox5.Text);
            cmd.Parameters.AddWithValue("@password", pTextBox6.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a>0)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script> alert('Registration Successfull');</script>");
                Response.Redirect("~/login.aspx");

            }

            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script> alert('Registration Failed');</script>");

            }
            con.Close();

        }
    }
}