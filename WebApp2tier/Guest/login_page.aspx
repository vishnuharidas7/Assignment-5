<%@ Page Title="Login Page" Language="C#" MasterPageFile="~/Guest/Guest.Master" AutoEventWireup="true" CodeBehind="login_page.aspx.cs" Inherits="WebApplication.Guest.login_page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <link rel="stylesheet" type="text/css" href="../Guest/login.css" />

    <br />
    <br />
    <center>
        <div>
            <br />
            <br />
            <h1>Login Form</h1>
           <table>
               <tr>
                   <td>
                       <asp:Label ID="lblusername" runat="server" Text="Username"></asp:Label>
                   </td>
                   <td>
                       <asp:TextBox ID="txtuser" runat="server"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtuser" ErrorMessage="Username Required" ForeColor="Red"></asp:RequiredFieldValidator>
                   </td>
               </tr>
                <tr>
                   <td>
                       Password</td>
                   <td>
                       <asp:TextBox ID="txtusrpass" runat="server" TextMode="password"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtusrpass" ErrorMessage="Password Required" ForeColor="Red"></asp:RequiredFieldValidator>
                   </td>
               </tr>

               <tr>
                   <td>
                       <asp:Button ID="Btnlogin" runat="server" Text="Login" OnClick="Btnlogin_Click" />
                   </td>
               </tr>
               <tr>
                   <td>
                       <asp:Label ID="lblwarn" runat="server"></asp:Label>
                   </td>
               </tr>
           </table>
        </div>
        </center>
</asp:Content>