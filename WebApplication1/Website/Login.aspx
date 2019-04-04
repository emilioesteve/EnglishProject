<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Website.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <link rel="stylesheet" href="StyleMaster.css" />
                    
                    <ul id="menu">
                        <li><a href="Home.aspx" class="auto-style3">Home</a></li>
                        <li><a href="Login.aspx" class="auto-style3">Login</a></li>
                    </ul>
               
     
               
                    
    <center>
    <div>
    <h4>Username:</h4>
    <asp:TextBox ID="User" runat="server"></asp:TextBox>
    <br />  
    <h4>Password:</h4>    
    <asp:TextBox ID="Password" runat="server"></asp:TextBox>
    <br />
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
        
        <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
        
        </div>

       
     </center>
</asp:Content>
