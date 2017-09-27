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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try { 
            var name = TextBox1.Text;
            var uname = TextBox2.Text;
            var password = TextBox3.Text;
            SqlConnection con = new SqlConnection("Data Source = SUYPC177; Initial Catalog = OnlineExam; User ID = sa; Password = Suyati123;Integrated Security=False");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select password from login where username='" + uname + "'", con);
            SqlDataReader dataReader = cmd1.ExecuteReader();

            if (dataReader.HasRows)
            {
                Response.Write("<script>alert('Username Already Exist' )</script>");
            }
            else
            {
                dataReader.Close();
                SqlCommand cmd = new SqlCommand("insert into login values('" + name + "','" + uname + "','" + password + "')", con);
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('Registration Successfull' )</script>");
                    FormsAuthentication.RedirectToLoginPage();
                }
            con.Close();
         }catch(Exception)
            {
                Response.Redirect("~/error.aspx");
            }
    }

    }

}
