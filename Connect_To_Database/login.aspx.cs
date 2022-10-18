using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Connect_To_Database
{
    public partial class login : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from signup_tbl where username=@user and password=@pass";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@user",TextBox1.Text);
            cmd.Parameters.AddWithValue("@pass",TextBox2.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                dr.Read();
                var dbusername = dr[5].ToString();
                var dbPassword = dr[7].ToString();
                dr.Close();
                if (dbusername == TextBox1.Text && dbPassword == TextBox2.Text)
                {

                    con.Close();
                    Response.Redirect("~/Dashboard.aspx");

                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script> alert('Login Faild');</script>");

                }

            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script> alert('Login Faild');</script>");

            }
            con.Close();

        }



    }

}