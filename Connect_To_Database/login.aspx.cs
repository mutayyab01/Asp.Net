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
            #region 1st Approach
            //SqlConnection con = new SqlConnection(cs);
            //string query = "select * from signup_tbl where username=@user and password=@pass;select * from signup_tbl where email=@email and password=@pass";
            //SqlCommand cmd = new SqlCommand(query, con);
            //cmd.Parameters.AddWithValue("@user",TextBox1.Text);
            //cmd.Parameters.AddWithValue("@email",TextBox1.Text);
            //cmd.Parameters.AddWithValue("@pass",TextBox2.Text);
            //con.Open();
            //SqlDataReader dr = cmd.ExecuteReader();
            //if (dr.HasRows == true)
            //{
            //    dr.Read();
            //    var dbusername = dr[5].ToString();
            //    var dbPassword = dr[7].ToString();
            //    dr.Close();
            //    if (dbusername == TextBox1.Text && dbPassword == TextBox2.Text)
            //    {

            //        con.Close();
            //        Response.Redirect("~/Dashboard.aspx");

            //    }
            //    else
            //    {
            //        Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script> alert('Login Faild');</script>");

            //    }

            //}
            //else if (dr.NextResult()==true)
            //{
            //    dr.Read();
            //    var dbemail = dr[6].ToString();
            //    var dbPassword = dr[7].ToString();
            //    dr.Close();
            //    if (dbemail == TextBox1.Text && dbPassword == TextBox2.Text)
            //    {

            //        con.Close();
            //        Response.Redirect("~/Dashboard.aspx");

            //    }
            //    else
            //    {
            //        Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script> alert('Login Faild');</script>");

            //    }
            //}
            //else
            //{
            //    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script> alert('Login Faild');</script>");

            //}
            //con.Close(); 
            #endregion

            SqlConnection con = new SqlConnection(cs);
            SqlConnection con2 = new SqlConnection(cs);
            string query = "select * from signup_tbl where username=@user and password=@pass";
            string query2 = "select * from signup_tbl where email=@email and password=@pass";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand cmd2 = new SqlCommand(query2, con);
            cmd.Parameters.AddWithValue("@user", TextBox1.Text);
            cmd.Parameters.AddWithValue("@pass", TextBox2.Text);
            cmd2.Parameters.AddWithValue("@email", TextBox2.Text);
            cmd2.Parameters.AddWithValue("@pass", TextBox2.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                dr.Read();
                var dbusername = dr[5].ToString();
                var dbemail = dr[6].ToString();
                var dbPassword = dr[7].ToString();
                dr.Close();
                if (((dbusername == TextBox1.Text) || (dbemail == TextBox1.Text)) && (dbPassword == TextBox2.Text))
                {

                    con.Close();
                    Response.Redirect("~/Dashboard.aspx");

                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script> alert('Login Faild');</script>");
                    con.Close();

                }
            }
            else if (dr.HasRows == false)
            {
                con2.Open();
                SqlDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.HasRows == true)
                {
                    dr2.Read();
                    var dbemail = dr[6].ToString();
                    var dbPassword = dr[7].ToString();
                    dr2.Close();
                    if (dbemail == TextBox1.Text && dbPassword == TextBox2.Text)
                    {
                        con2.Close();
                        Response.Redirect("~/Dashboard.aspx");
                    }
                    else
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script> alert('Login Faild');</script>");
                        con2.Close();
                    }

                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script> alert('Login Faild');</script>");
                    con2.Close();
                }

            }
            
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script> alert('Login Faild');</script>");
                con.Close();

            }








































        }



    }

}