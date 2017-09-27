using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExam
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void Button1_Click(object sender, EventArgs e)
        {
            ///<summary>
            ///Login Button
            ///</summary>
            try
            { 
            var lname = TextBox1.Text;  //user entered username
            var lpass = TextBox2.Text;  //user entered password

            SqlConnection con = new SqlConnection("Data Source = SUYPC177; Initial Catalog = OnlineExam; User ID = sa; Password = Suyati123;Integrated Security=False");
            SqlCommand cmd = new SqlCommand("select * from login where username='" + lname + "'", con);
            con.Open();

            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows)  //checks if user Exist
            {
                while (dataReader.Read())
                {
                    var cpass = dataReader["password"].ToString().TrimEnd();

                    if (cpass.Equals(lpass))  // checks password
                    {
                        Session["user"] = dataReader["name"].ToString().TrimEnd();
                        Session["userid"] = dataReader["username"].ToString().TrimEnd();
                        FormsAuthentication.RedirectFromLoginPage(lname, true); // login successfull and gets redirected
                    }
                    else
                    {
                        Response.Write("<script>alert('Invalid Password')</script>");
                    }
                }
            }
            else
            {
                Response.Write("<script>alert('Invalid Username')</script>");
            }
            con.Close();
        }catch(Exception )
            {
                Response.Redirect("~/error.aspx");
            }
    }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx"); //redirect to register page
        }
    }
}