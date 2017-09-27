using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExam
{
    public partial class result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try { 
                //getting the user entered options
            SqlConnection con = new SqlConnection("Data Source = SUYPC177; Initial Catalog = OnlineExam; User ID = sa; Password = Suyati123;Integrated Security=False");
            SqlCommand cmd1 = new SqlCommand("select * from Test where username='" + Session["userid"].ToString() + "'", con);
            con.Open();
            SqlDataReader dataReader1 = cmd1.ExecuteReader();
            dataReader1.Read();
            if(dataReader1.HasRows)
            {
                ans1.Text = dataReader1["q1"].ToString();
                ans2.Text = dataReader1["q2"].ToString();
                ans3.Text = dataReader1["q3"].ToString();
                ans4.Text = dataReader1["q4"].ToString();
                ans5.Text = dataReader1["q5"].ToString();
                ans6.Text = dataReader1["q6"].ToString();
                ans7.Text = dataReader1["q7"].ToString();
                ans8.Text = dataReader1["q8"].ToString();
                ans9.Text = dataReader1["q9"].ToString();
                ans10.Text = dataReader1["q10"].ToString();
                dataReader1.Close();
                  
                string[] a = new string[10];
                    int i = 0;

               //getting the correct options
                    SqlCommand cmd = new SqlCommand("select correct from Question", con);
            
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while(dataReader.Read())
                    {
                        a[i] = dataReader["correct"].ToString();
                        i++;
                    }

                    int j = 0;
                    //comparing if the user entered and correct options are same ,if same background in green else background is red
                    c1.Text = a[0];
                     if(ans1.Text==c1.Text)
                    {
                        ans1.BackColor = System.Drawing.Color.Green;
                        j++;
                    }
                    else
                    {
                        ans1.BackColor = System.Drawing.Color.Red;
                    }
                    c2.Text = a[1];
                    if (ans2.Text == c2.Text)
                    {
                        ans2.BackColor = System.Drawing.Color.Green;
                        j++;
                    }
                    else
                    {
                        ans2.BackColor = System.Drawing.Color.Red;
                    }
                    c3.Text = a[2];
                    if (ans3.Text == c3.Text)
                    {
                        ans3.BackColor = System.Drawing.Color.Green;
                        j++;
                    }
                    else
                    {
                        ans3.BackColor = System.Drawing.Color.Red;
                    }
                    c4.Text = a[3];
                    if (ans4.Text == c4.Text)
                    {
                        ans4.BackColor = System.Drawing.Color.Green;
                        j++;
                    }
                    else
                    {
                        ans4.BackColor = System.Drawing.Color.Red;
                    }
                    c5.Text = a[4];
                    if (ans5.Text == c5.Text)
                    {
                        ans5.BackColor = System.Drawing.Color.Green;
                        j++;
                    }
                    else
                    {
                        ans5.BackColor = System.Drawing.Color.Red;
                    }
                    c6.Text = a[5];
                    if (ans6.Text == c6.Text)
                    {
                        ans6.BackColor = System.Drawing.Color.Green;
                        j++;
                    }
                    else
                    {
                        ans6.BackColor = System.Drawing.Color.Red;
                    }
                    c7.Text = a[6];
                    if (ans7.Text == c7.Text)
                    {
                        ans7.BackColor = System.Drawing.Color.Green;
                        j++;
                    }
                    else
                    {
                        ans7.BackColor = System.Drawing.Color.Red;
                    }
                    c8.Text = a[7];
                    if (ans8.Text == c8.Text)
                    {
                        ans8.BackColor = System.Drawing.Color.Green;
                        j++;
                    }
                    else
                    {
                        ans8.BackColor = System.Drawing.Color.Red;
                    }
                    c9.Text = a[8];
                    if (ans9.Text == c9.Text)
                    {
                        ans9.BackColor = System.Drawing.Color.Green;
                        j++;
                    }
                    else
                    {
                        ans9.BackColor = System.Drawing.Color.Red;
                    }
                    c10.Text = a[9];
                    if (ans10.Text == c10.Text)
                    {
                        ans10.BackColor = System.Drawing.Color.Green;
                        j++;
                    }
                    else
                    {
                        ans10.BackColor = System.Drawing.Color.Red;
                    }
                    dataReader.Close();
                    int score = j * 2;
                    Label3.Text = Session["user"].ToString();
                    Label5.Text = score.ToString();
                    Label9.Text= j.ToString();
                }
            else
            { //if no reult is found for the user
                Response.Write("<script>alert('NO Results Found' )</script>");        
            }

            }
            catch (Exception)
            {
                Response.Redirect("error.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }
    }
}