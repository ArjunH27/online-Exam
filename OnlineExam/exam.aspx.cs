using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExam
{
    public partial class exam : System.Web.UI.Page
    {
        
        public int count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            try {    
            SqlConnection con = new SqlConnection("Data Source = SUYPC177; Initial Catalog = OnlineExam; User ID = sa; Password = Suyati123;Integrated Security=False");
            //q1
            SqlCommand cmd = new SqlCommand("select * from Question where questionID='" + "q1" + "'",con);
            con.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            dataReader.Read();
            Label1.Text = dataReader["question"].ToString();
            RadioButton1.Text = dataReader["option1"].ToString();
            RadioButton2.Text = dataReader["option2"].ToString();
            RadioButton3.Text = dataReader["option3"].ToString();
            RadioButton4.Text = dataReader["option4"].ToString();
            con.Close();
            dataReader.Close();
            //q2
            SqlCommand cmd1 = new SqlCommand("select * from Question where questionID='" + "q2" + "'", con);
            con.Open();
            SqlDataReader dataReader1 = cmd1.ExecuteReader();
            dataReader1.Read();
            Label2.Text = dataReader1["question"].ToString();
            RadioButton5.Text = dataReader1["option1"].ToString();
            RadioButton6.Text = dataReader1["option2"].ToString();
            RadioButton7.Text = dataReader1["option3"].ToString();
            RadioButton8.Text = dataReader1["option4"].ToString();
            con.Close();
            dataReader1.Close();
            //q3
            SqlCommand cmd2 = new SqlCommand("select * from Question where questionID='" + "q3" + "'", con);
            con.Open();
            SqlDataReader dataReader2 = cmd2.ExecuteReader();
            dataReader2.Read();
            Label3.Text = dataReader2["question"].ToString();
            RadioButton9.Text = dataReader2["option1"].ToString();
            RadioButton10.Text = dataReader2["option2"].ToString();
            RadioButton11.Text = dataReader2["option3"].ToString();
            RadioButton12.Text = dataReader2["option4"].ToString();
            con.Close();
            dataReader2.Close();
            //q4
            SqlCommand cmd3 = new SqlCommand("select * from Question where questionID='" + "q4" + "'", con);
            con.Open();
            SqlDataReader dataReader3 = cmd3.ExecuteReader();
            dataReader3.Read();
            Label4.Text = dataReader3["question"].ToString();
            RadioButton13.Text = dataReader3["option1"].ToString();
            RadioButton14.Text = dataReader3["option2"].ToString();
            RadioButton15.Text = dataReader3["option3"].ToString();
            RadioButton16.Text = dataReader3["option4"].ToString();
            con.Close();
            dataReader3.Close();
            //q5
            SqlCommand cmd4 = new SqlCommand("select * from Question where questionID='" + "q5" + "'", con);
            con.Open();
            SqlDataReader dataReader4 = cmd4.ExecuteReader();
            dataReader4.Read();
            Label5.Text = dataReader4["question"].ToString();
            RadioButton17.Text = dataReader4["option1"].ToString();
            RadioButton18.Text = dataReader4["option2"].ToString();
            RadioButton19.Text = dataReader4["option3"].ToString();
            RadioButton20.Text = dataReader4["option4"].ToString();
            con.Close();
            dataReader4.Close();
            //q6
            SqlCommand cmd5 = new SqlCommand("select * from Question where questionID='" + "q6" + "'", con);
            con.Open();
            SqlDataReader dataReader5 = cmd5.ExecuteReader();
            dataReader5.Read();
            Label6.Text = dataReader5["question"].ToString();
            RadioButton21.Text = dataReader5["option1"].ToString();
            RadioButton22.Text = dataReader5["option2"].ToString();
            RadioButton23.Text = dataReader5["option3"].ToString();
            RadioButton24.Text = dataReader5["option4"].ToString();
            con.Close();
            dataReader5.Close();
            //q7
            SqlCommand cmd6 = new SqlCommand("select * from Question where questionID='" + "q7" + "'", con);
            con.Open();
            SqlDataReader dataReader6 = cmd6.ExecuteReader();
            dataReader6.Read();
            Label7.Text = dataReader6["question"].ToString();
            RadioButton25.Text = dataReader6["option1"].ToString();
            RadioButton26.Text = dataReader6["option2"].ToString();
            RadioButton27.Text = dataReader6["option3"].ToString();
            RadioButton28.Text = dataReader6["option4"].ToString();
            con.Close();
            dataReader6.Close();
            //q8
            SqlCommand cmd7 = new SqlCommand("select * from Question where questionID='" + "q8" + "'", con);
            con.Open();
            SqlDataReader dataReader7 = cmd7.ExecuteReader();
            dataReader7.Read();
            Label8.Text = dataReader7["question"].ToString();
            RadioButton29.Text = dataReader7["option1"].ToString();
            RadioButton30.Text = dataReader7["option2"].ToString();
            RadioButton31.Text = dataReader7["option3"].ToString();
            RadioButton32.Text = dataReader7["option4"].ToString();
            con.Close();
            dataReader7.Close();
            //q9
            SqlCommand cmd8 = new SqlCommand("select * from Question where questionID='" + "q9" + "'", con);
            con.Open();
            SqlDataReader dataReader8 = cmd8.ExecuteReader();
            dataReader8.Read();
            Label9.Text = dataReader8["question"].ToString();
            RadioButton33.Text = dataReader8["option1"].ToString();
            RadioButton34.Text = dataReader8["option2"].ToString();
            RadioButton35.Text = dataReader8["option3"].ToString();
            RadioButton36.Text = dataReader8["option4"].ToString();
            con.Close();
            dataReader8.Close();
            //q10
            SqlCommand cmd9 = new SqlCommand("select * from Question where questionID='" + "qlast" + "'", con);
            con.Open();
            SqlDataReader dataReader9 = cmd9.ExecuteReader();
            dataReader9.Read();
            Label10.Text = dataReader9["question"].ToString();
            RadioButton37.Text = dataReader9["option1"].ToString();
            RadioButton38.Text = dataReader9["option2"].ToString();
            RadioButton39.Text = dataReader9["option3"].ToString();
            RadioButton40.Text = dataReader9["option4"].ToString();
            con.Close();
            dataReader9.Close();



            if (!IsPostBack)
            {
                MultiView1.ActiveViewIndex = 0;
            }

            }
            catch (Exception)
            {
                Response.Redirect("error.aspx");
            }
        }
        protected void Next_Click(object sender, EventArgs e)
        {

            int index = MultiView1.ActiveViewIndex;           
            
            count= index + 1;
            MultiView1.SetActiveView(MultiView1.Views[count]);
            
        }

        protected void Prev_Click(object sender, EventArgs e)
        {
            int index = MultiView1.ActiveViewIndex;
           
            
            count = index - 1;
            MultiView1.SetActiveView(MultiView1.Views[count]);
           
        }

        protected void Button19_Click(object sender, EventArgs e)
        {
            //try { 
            var ans1 = "Not Answered";
            if (RadioButton1.Checked)
            {
                ans1 = RadioButton1.Text;
            }
            else if (RadioButton2.Checked)
            {
                ans1 = RadioButton2.Text;
            }
            else if(RadioButton3.Checked)
            {
                ans1 = RadioButton3.Text;
            }
            else
            {
                ans1 = RadioButton4.Text;
            }

            var ans2 = "Not Answered";
            if (RadioButton5.Checked)
            {
                ans2 = RadioButton5.Text;
            }
            else if (RadioButton6.Checked)
            {
                ans2 = RadioButton6.Text;
            }
            else if (RadioButton7.Checked)
            {
                ans2 = RadioButton7.Text;
            }
            else
            {
                ans2 = RadioButton8.Text;
            }


            var ans3 = "Not Answered";
            if (RadioButton9.Checked)
            {
                ans3 = RadioButton9.Text;
            }
            else if (RadioButton10.Checked)
            {
                ans3 = RadioButton10.Text;
            }
            else if (RadioButton11.Checked)
            {
                ans3 = RadioButton11.Text;
            }
            else
            {
                ans3 = RadioButton12.Text;
            }

            var ans4 = "Not Answered";
            if (RadioButton13.Checked)
            {
                ans4 = RadioButton13.Text;
            }
            else if (RadioButton14.Checked)
            {
                ans4 = RadioButton14.Text;
            }
            else if (RadioButton15.Checked)
            {
                ans4 = RadioButton15.Text;
            }
            else
            {
                ans4 = RadioButton16.Text;
            }


            var ans5 = "Not Answered";
            if (RadioButton17.Checked)
            {
                ans5 = RadioButton17.Text;
            }
            else if (RadioButton18.Checked)
            {
                ans5 = RadioButton18.Text;
            }
            else if (RadioButton19.Checked)
            {
                ans5 = RadioButton19.Text;
            }
            else
            {
                ans5 = RadioButton20.Text;
            }

            var ans6 = "Not Answered";
            if (RadioButton21.Checked)
            {
                ans6 = RadioButton21.Text;
            }
            else if (RadioButton22.Checked)
            {
                ans6 = RadioButton22.Text;
            }
            else if (RadioButton23.Checked)
            {
                ans6 = RadioButton23.Text;
            }
            else
            {
                ans6 = RadioButton24.Text;
            }

            var ans7 = "Not Answered";
            if (RadioButton25.Checked)
            {
                ans7 = RadioButton25.Text;
            }
            else if (RadioButton26.Checked)
            {
                ans7 = RadioButton26.Text;
            }
            else if (RadioButton27.Checked)
            {
                ans7 = RadioButton27.Text;
            }
            else
            {
                ans7 = RadioButton28.Text;
            }

            var ans8 = "Not Answered";
            if (RadioButton29.Checked)
            {
                ans8 = RadioButton29.Text;
            }
            else if (RadioButton30.Checked)
            {
                ans8 = RadioButton30.Text;
            }
            else if (RadioButton31.Checked)
            {
                ans8 = RadioButton31.Text;
            }
            else
            {
                ans8 = RadioButton32.Text;
            }

            var ans9 = "Not Answered";
            if (RadioButton33.Checked)
            {
                ans9 = RadioButton33.Text;
            }
            else if (RadioButton34.Checked)
            {
                ans9 = RadioButton34.Text;
            }
            else if (RadioButton35.Checked)
            {
                ans9 = RadioButton35.Text;
            }
            else
            {
                ans9 = RadioButton36.Text;
            }


            var ans10 = "Not Answered";
            if (RadioButton37.Checked)
            {
                ans10 = RadioButton37.Text;
            }
            else if (RadioButton38.Checked)
            {
                ans10 = RadioButton38.Text;
            }
            else if (RadioButton39.Checked)
            {
                ans10 = RadioButton39.Text;
            }
            else
            {
                ans10= RadioButton40.Text;
            }
            SqlConnection con = new SqlConnection("Data Source = SUYPC177; Initial Catalog = OnlineExam; User ID = sa; Password = Suyati123;Integrated Security=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Test where username='" + Session["userid"].ToString() + "'", con);
            SqlDataReader dataReader = cmd.ExecuteReader();
            dataReader.Read();
            if (dataReader.HasRows)
            {
                SqlCommand cmd1 = new SqlCommand("delete from Test where username='"+ Session["userid"].ToString()+"'", con);
                dataReader.Close();
                    
                cmd1.ExecuteNonQuery();
            }
                SqlCommand cmd2 = new SqlCommand("insert into Test values('" + Session["userid"].ToString() + "','" + Session["user"].ToString() + "','" + ans1 + "','" + ans2 + "','" + ans3 + "','" + ans4 + "','" + ans5 + "','" + ans6 + "','" + ans7 + "','" + ans8 + "','" + ans9 + "','" + ans10 + "')", con);
            dataReader.Close();
            cmd2.ExecuteNonQuery();
            con.Close();
            Response.Redirect("home.aspx");
            //}
            //catch (Exception)
            //{
            //    Response.Redirect("error.aspx");
            //}
       }
    }
}