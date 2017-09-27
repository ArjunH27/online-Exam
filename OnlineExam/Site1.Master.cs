using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExam
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Label1.Text = Session["user"].ToString();
            }
            catch(Exception )
            {
                Response.Redirect("error.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        { //signout button ,sessions are cleared and redirected to login page

            Session.Abandon();
            Session.Clear();
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
         

        }
    }
}