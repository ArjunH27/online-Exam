<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="result.aspx.cs" Inherits="OnlineExam.result" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
     .wrapper {	
	           
                width: 975px;                
                margin: 0 auto;
                background-color: #DADADA;    
                box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2);           
            }

     .tab{
         text-align:center;        
     }
     .correct{
         background-color:green;
     }
     .card{
         margin:0 auto;
         width:200px;
         background-image:url("http://media.istockphoto.com/photos/white-background-picture-id475709907?k=6&m=475709907&s=612x612&w=0&h=9SThTmaUYTSLhjAR2Bk7frtYkS8XTaTAUp2fQByJydA=");
         box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2);
     }
    </style>
    <div class="wrapper">
    <asp:Table ID="Table1" runat="server" BorderStyle="Solid" BorderWidth="1"  CellPadding="3" CellSpacing="10" GridLines="Both" Width="976px"  CssClass="tab">
        <asp:TableRow>
            <asp:TableHeaderCell >Question Number</asp:TableHeaderCell>
            <asp:TableHeaderCell>Your Answer</asp:TableHeaderCell>
            <asp:TableHeaderCell>Correct Answer</asp:TableHeaderCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>1.</asp:TableCell>
            <asp:TableCell ID="ans1" ></asp:TableCell>
            <asp:TableCell ID="c1"></asp:TableCell>
        </asp:TableRow>
          <asp:TableRow>
            <asp:TableCell>2.</asp:TableCell>
            <asp:TableCell ID="ans2"></asp:TableCell>
            <asp:TableCell ID="c2"></asp:TableCell>
        </asp:TableRow>
          <asp:TableRow>
            <asp:TableCell>3.</asp:TableCell>
            <asp:TableCell ID="ans3"></asp:TableCell>
            <asp:TableCell ID="c3"></asp:TableCell>
        </asp:TableRow>
          <asp:TableRow>
            <asp:TableCell>4.</asp:TableCell>
            <asp:TableCell ID="ans4"></asp:TableCell>
            <asp:TableCell ID="c4"></asp:TableCell>
        </asp:TableRow>
          <asp:TableRow>
            <asp:TableCell>5.</asp:TableCell>
            <asp:TableCell ID="ans5"></asp:TableCell>
            <asp:TableCell ID="c5"></asp:TableCell>
        </asp:TableRow>
          <asp:TableRow>
            <asp:TableCell>6.</asp:TableCell>
            <asp:TableCell ID="ans6"></asp:TableCell>
            <asp:TableCell ID="c6"></asp:TableCell>
        </asp:TableRow>
          <asp:TableRow>
            <asp:TableCell>7.</asp:TableCell>
            <asp:TableCell ID="ans7"></asp:TableCell>
            <asp:TableCell ID="c7"></asp:TableCell>
        </asp:TableRow>
          <asp:TableRow>
            <asp:TableCell>8.</asp:TableCell>
            <asp:TableCell ID="ans8"></asp:TableCell>
            <asp:TableCell ID="c8"></asp:TableCell>
        </asp:TableRow>
          <asp:TableRow>
            <asp:TableCell>9.</asp:TableCell>
            <asp:TableCell ID="ans9"></asp:TableCell>
            <asp:TableCell ID="c9"></asp:TableCell>
        </asp:TableRow>
          <asp:TableRow>
            <asp:TableCell>10.</asp:TableCell>
            <asp:TableCell ID="ans10"></asp:TableCell>
            <asp:TableCell ID="c10"></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
        </div>
    &nbsp;&nbsp;
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />    
    <div class="card">
      &nbsp;<asp:Label ID="Label2" runat="server" Text="NAME : "></asp:Label>
        &nbsp;&nbsp;
      <asp:Label ID="Label3" runat="server"></asp:Label>
        <br />
&nbsp;<asp:Label ID="Label6" runat="server" Text="TOTAL :"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label7" runat="server" Text="20"></asp:Label>
        <br />
&nbsp;<asp:Label ID="Label8" runat="server" Text="CORRECT :"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
        <br />
&nbsp;<asp:Label ID="Label4" runat="server" Text="SCORE : "></asp:Label>
    &nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server"></asp:Label>
        <br />
        <br />
    </div>
    <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="FINISH" OnClick="Button1_Click" Width="151px" />

</asp:Content>
