using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_NET_WebForm_Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string userid = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            string connectionString = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
            string query = "SELECT COUNT(*) FROM users WHERE userid = @userid AND password = @password";

            using (SqlConnection conn = new SqlConnection(connectionString)) {
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userid", userid);
                    cmd.Parameters.AddWithValue("@password", password);
                    conn.Open();
                    int result = (int)cmd.ExecuteScalar();

                    if(result > 0)
                    {
                        Response.Redirect("Welcome.aspx");
                    }
                    else
                    {
                        lblMessage.Text = "Invalid userid or password.";
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }

            //if (userid == "admin" && password == "admin123")
            //{
            //    //lblMessage.Text = "Login successful";
            //    //lblMessage.ForeColor = System.Drawing.Color.Green;
            //    Response.Redirect("Welcome.aspx");
            //}
            //else
            //{
            //    lblMessage.Text = "Invalid userid or password";
            //    lblMessage.ForeColor = System.Drawing.Color.Red;
            //}
        }
    }
}