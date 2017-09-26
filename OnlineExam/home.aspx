<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="OnlineExam.home" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <br /><br /><br />
    <style>
        #id1 {
            margin-left: 100px;
        }
    </style>
    
    <div class="col-md-5 column productbox" id="id1">
    <img src="https://cdn1.iconfinder.com/data/icons/survey/500/Questionnaire_sign-512.png" class="img-responsive"/>
    <div class="producttitle">Exam consist of 10 Quistions<br />Retaking the Exam will remove your old Result </div><br />
    <a href="exam.aspx"  style="float:left" role="button"><h3>TAKE EXAM</h3></a>
</div>

<div class="col-md-5 column productbox" id="id1">
    <img src="https://cdn0.iconfinder.com/data/icons/education-15/500/result-512.png" class="img-responsive">
    <div class="producttitle">View Your Exam Result</div><br />
    <a href="result.aspx" style="float:left"   role="button"><h3>VIEW RESULT</h3></a>
</div>
    
</asp:Content>
