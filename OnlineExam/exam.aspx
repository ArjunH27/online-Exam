<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="exam.aspx.cs" Inherits="OnlineExam.exam" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
                   .wrapper {	
	           
                width: 1255px;
                padding: 15px 35px 45px;
                margin: 0 auto;
                background-color: #DADADA;
                border: 1px solid rgba(0,0,0,0.1);
            }
    </style>
    <div class="wrapper">
    <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0" >
        
        <asp:View ID="View1" runat="server" >
            &nbsp;<asp:Label ID="Label11" runat="server" Text="Question 1."></asp:Label>
            &nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br /><br />
            <asp:RadioButton ID="RadioButton1" GroupName="q1" runat="server"  />
            <asp:RadioButton ID="RadioButton2" GroupName="q1" runat="server" />
            <asp:RadioButton ID="RadioButton3" GroupName="q1" runat="server" />
            <asp:RadioButton ID="RadioButton4" GroupName="q1" runat="server" />
            <br /><br />
            <asp:Button ID="Button1" runat="server" Text="NEXT" OnClick="Next_Click" />
        </asp:View>
        <asp:View ID="View2" runat="server">
            &nbsp;<asp:Label ID="Label12" runat="server" Text="Question 2."></asp:Label>
            &nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Labe2"></asp:Label>
            <br /><br />
            <asp:RadioButton ID="RadioButton5" GroupName="q2" runat="server" />
            <asp:RadioButton ID="RadioButton6" GroupName="q2" runat="server" />
            <asp:RadioButton ID="RadioButton7" GroupName="q2" runat="server" />
            <asp:RadioButton ID="RadioButton8" GroupName="q2" runat="server" />
            <br /><br />
            <asp:Button ID="Button2" runat="server" Text="PREVIOUS" OnClick="Prev_Click" />
            &nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Next_Click" Text="NEXT" />
        </asp:View>
        <asp:View ID="View3" runat="server">
            &nbsp;<asp:Label ID="Label13" runat="server" Text="Question 3."></asp:Label>
            &nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Labe3"></asp:Label>
            <br /><br />
             <asp:RadioButton ID="RadioButton9" GroupName="q3" runat="server" />
            <asp:RadioButton ID="RadioButton10" GroupName="q3" runat="server" />
            <asp:RadioButton ID="RadioButton11" GroupName="q3" runat="server" />
            <asp:RadioButton ID="RadioButton12" GroupName="q3" runat="server" />
            <br /><br />
            <asp:Button ID="Button4" runat="server" Text="PREVIOUS" OnClick="Prev_Click" />
            &nbsp;&nbsp;
            <asp:Button ID="Button5" runat="server" Text="NEXT" OnClick="Next_Click" />
        </asp:View>
        <asp:View ID="View4" runat="server">
            &nbsp;<asp:Label ID="Label14" runat="server" Text="Question 4."></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="Labe4"></asp:Label>
            <br /><br />
            <asp:RadioButton ID="RadioButton13" GroupName="q4" runat="server" />
            <asp:RadioButton ID="RadioButton14" GroupName="q4" runat="server" />
            <asp:RadioButton ID="RadioButton15" GroupName="q4" runat="server" />
            <asp:RadioButton ID="RadioButton16" GroupName="q4" runat="server" />
            <br /><br />
            <asp:Button ID="Button6" runat="server" Text="PREVIOUS" OnClick="Prev_Click" />
            &nbsp;&nbsp;
            <asp:Button ID="Button7" runat="server" Text="NEXT" OnClick="Next_Click" />
        </asp:View>
        <asp:View ID="View5" runat="server">
            &nbsp;<asp:Label ID="Label15" runat="server" Text="Question 5."></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" Text="Labe5"></asp:Label>
            <br /><br />
             <asp:RadioButton ID="RadioButton17" GroupName="q5" runat="server" />
            <asp:RadioButton ID="RadioButton18" GroupName="q5" runat="server" />
            <asp:RadioButton ID="RadioButton19" GroupName="q5" runat="server" />
            <asp:RadioButton ID="RadioButton20" GroupName="q5" runat="server" />
            <br /><br />
            <asp:Button ID="Button8" runat="server" Text="PREVIOUS" OnClick="Prev_Click" />
            &nbsp;&nbsp;
            <asp:Button ID="Button9" runat="server" Text="NEXT" OnClick="Next_Click" />
        </asp:View>
        <asp:View ID="View6" runat="server">
             &nbsp;<asp:Label ID="Label16" runat="server" Text="Question 6."></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Label ID="Label6" runat="server" Text="Labe6"></asp:Label>
             <br /><br />
            <asp:RadioButton ID="RadioButton21" GroupName="q6" runat="server" />
            <asp:RadioButton ID="RadioButton22" GroupName="q6" runat="server" />
            <asp:RadioButton ID="RadioButton23" GroupName="q6" runat="server" />
            <asp:RadioButton ID="RadioButton24" GroupName="q6" runat="server" />
             <br /><br />
            <asp:Button ID="Button10" runat="server" Text="PREVIOUS" OnClick="Prev_Click" />
             &nbsp;&nbsp;
            <asp:Button ID="Button11" runat="server" Text="NEXT" OnClick="Next_Click" />
        </asp:View>
        <asp:View ID="View7" runat="server">
            &nbsp;
            <asp:Label ID="Label17" runat="server" Text="Question 7."></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label7" runat="server" Text="Labe7"></asp:Label>
            <br /><br />
            <asp:RadioButton ID="RadioButton25" GroupName="q7" runat="server" />
            <asp:RadioButton ID="RadioButton26" GroupName="q7" runat="server" />
            <asp:RadioButton ID="RadioButton27" GroupName="q7" runat="server" />
            <asp:RadioButton ID="RadioButton28" GroupName="q7" runat="server" />
            <br /><br />
            <asp:Button ID="Button12" runat="server" Text="PREVIOUS" OnClick="Prev_Click" />
            &nbsp;&nbsp;
            <asp:Button ID="Button13" runat="server" Text="NEXT" OnClick="Next_Click" />
        </asp:View>
        <asp:View ID="View8" runat="server">
             &nbsp;<asp:Label ID="Label18" runat="server" Text="Question 8."></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Label ID="Label8" runat="server" Text="Labe8"></asp:Label>
             <br /><br />
             <asp:RadioButton ID="RadioButton29" GroupName="q8" runat="server" />
            <asp:RadioButton ID="RadioButton30" GroupName="q8" runat="server" />
            <asp:RadioButton ID="RadioButton31" GroupName="q8" runat="server" />
            <asp:RadioButton ID="RadioButton32" GroupName="q8" runat="server" />
             <br /><br />
            <asp:Button ID="Button14" runat="server" Text="PREVIOUS" OnClick="Prev_Click" />
             &nbsp;&nbsp;
            <asp:Button ID="Button15" runat="server" Text="NEXT" OnClick="Next_Click" />
        </asp:View>
        <asp:View ID="View9" runat="server">
             &nbsp;<asp:Label ID="Label19" runat="server" Text="Question 9."></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Label ID="Label9" runat="server" Text="Labe9"></asp:Label>
             <br /><br />
            <asp:RadioButton ID="RadioButton33" GroupName="q9" runat="server" />
            <asp:RadioButton ID="RadioButton34" GroupName="q9" runat="server" />
            <asp:RadioButton ID="RadioButton35" GroupName="q9" runat="server" />
            <asp:RadioButton ID="RadioButton36" GroupName="q9" runat="server" />
             <br /><br />
            <asp:Button ID="Button16" runat="server" Text="PREVIOUS" OnClick="Prev_Click" />
             &nbsp;&nbsp;
            <asp:Button ID="Button17" runat="server" Text="NEXT" OnClick="Next_Click" />
        </asp:View>
        <asp:View ID="View10" runat="server">
             &nbsp;<asp:Label ID="Label20" runat="server" Text="Question 10."></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Label ID="Label10" runat="server" Text="Labe10"></asp:Label>
             <br /><br />
            <asp:RadioButton ID="RadioButton37" GroupName="q10" runat="server" />
            <asp:RadioButton ID="RadioButton38" GroupName="q10" runat="server" />
            <asp:RadioButton ID="RadioButton39" GroupName="q10" runat="server" />
            <asp:RadioButton ID="RadioButton40" GroupName="q10" runat="server" />
             <br /><br />
            <asp:Button ID="Button18" runat="server" Text="PREVIOUS" OnClick="Prev_Click" />
           
             &nbsp;&nbsp;
             <asp:Button ID="Button19" runat="server" OnClick="Button19_Click" Text="SUBMIT" />
           
        </asp:View>
    </asp:MultiView>
    </div>

</asp:Content>
