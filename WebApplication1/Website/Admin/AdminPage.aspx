<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="Website.Admin.AdminPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            width: 497px;
            height: 262px;
        }
        .auto-style5 {
            height: 262px;
            width: 433px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%; height: 223px; margin-top: 0px;">
        <tr>
            <td class="auto-style4">Name: :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                Id&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                
                Age:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br />
                Psasword:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <br />
                Nationality:&nbsp;&nbsp;
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Student" />
            </td>
            <td class="auto-style5">
                <asp:ListBox ID="ListBox2" runat="server" Height="146px" Width="401px"></asp:ListBox>
                &nbsp;
                <br />
                <br />
                <asp:Button ID="Button3" runat="server" Text="Delete" Width="94px" OnClick="Button3_Click" />
            &nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Text="Modify" Width="91px" OnClick="Button2_Click" />
            &nbsp;&nbsp;
                <asp:TextBox ID="TextBox6" runat="server" Width="82px"></asp:TextBox>
&nbsp;
                <asp:TextBox ID="TextBox7" runat="server" Width="86px"></asp:TextBox>
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Age&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Password<br />
                ID: <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            </td>
            <td>


                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="LogOut" Width="74px" />


            </td>
        </tr>
      

        </table>

    

</asp:Content>
