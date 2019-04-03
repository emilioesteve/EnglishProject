<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="Website.Admin.AdminPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%; height: 223px; margin-top: 0px;">
        <tr>
            <td>Student:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                Nationality:&nbsp;
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                Age:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br />
                Password:&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <br />
                Id:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                <br />
                <br />
                <input id="Button1" type="button" value="Add Student" /></td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>
