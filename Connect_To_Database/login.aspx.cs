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
            string query = "select * from signup_tbl where username=@username and password=@pass;select * from signup_tbl where email=@email and password=@pass";
            string query2 = "select * from signup_tbl where email=@email and password=@pass";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand cmd2 = new SqlCommand(query2, con);
            cmd.Parameters.AddWithValue("@username", TextBox1.Text);
            cmd.Parameters.AddWithValue("@pass", TextBox2.Text);
            cmd.Parameters.AddWithValue("@email", TextBox1.Text);
            cmd2.Parameters.AddWithValue("@email", TextBox1.Text);
            cmd2.Parameters.AddWithValue("@pass", TextBox2.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            //con.Close();

            //con.Open();
            bool res = dr.NextResult();
            //SqlDataReader dr2 = cmd.ExecuteReader();
            //con.Close();


            //con.Open();
            if ((dr.HasRows == true) || (res == true) /*|| (dr2.HasRows == true)*/)
            {
                var dbpassword = "";
                var dbusername = "";
                var useremail = "";

                if (dr.HasRows == true || (res == true))
                {
                    dr.Read();
                    dbusername = dr[5].ToString();
                    dbpassword = dr[7].ToString();
                    useremail = dr[6].ToString();
                    dr.Close();

                }
                //else if (dr2.HasRows == true)
                //{
                //    dr2.Read();
                //    dbusername = dr[5].ToString();
                //    dbpassword = dr[7].ToString();
                //    useremail = dr[6].ToString();
                //    dr2.Close();
                //}

                if (((dbusername == TextBox1.Text) || useremail == TextBox1.Text) && (dbpassword == TextBox2.Text))
                {
                    Session["user"] = TextBox1.Text;
                    con.Close();
                    Response.Redirect("~/Dashboard.aspx");

                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script> alert('Login Faild');</script>");
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