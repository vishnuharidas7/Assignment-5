<%@ Page Title="My Profile" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="User_profile.aspx.cs" Inherits="WebApplication.User.User_Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div><link rel="stylesheet" type="text/css" href="1.css" />
    <center>
        <h1>My Profile</h1>
    <table>
        <tr>
            <td>
                <asp:Label runat="server" Text="Name"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblname" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>

        <tr>
             <td>
                <asp:Label runat="server" Text="Email"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblemail" runat="server" Text="Label"></asp:Label>

            </td>
        </tr>

        <tr>
             <td>
                <asp:Label runat="server" Text="Age"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblage" runat="server" Text="Label"></asp:Label>

            </td>
        </tr>

        <tr>
             <td>
                <asp:Label runat="server" Text="Gender"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblgen" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>

        <tr>
             <td>
                <asp:Label runat="server" Text="Username"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblusr" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>

    </table>
        </center>
           </div>
</asp:Content>
