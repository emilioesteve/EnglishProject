<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Website.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   

    <center>
    <div>
    <h4>Username:</h4>
    <asp:TextBox ID="UserLogin" runat="server"></asp:TextBox>
    <br />  
    <h4>Password:</h4>    
    <asp:TextBox ID="PassLogin" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Secure" runat="server" Text="Login" Width="144px" OnClick="Secure_Click2"    />
        
        <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
        
        </div>
     </center>
</asp:Content>
