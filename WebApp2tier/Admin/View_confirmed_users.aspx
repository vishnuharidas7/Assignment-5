<%@ Page Title="Confirmed Users" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="View_confirmed_users.aspx.cs" Inherits="WebApp2tier.Admin.View_confirmed_users" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div><link rel="stylesheet" type="text/css" href="Admin.css" />
        <br />
        <div>
            <asp:Button ID="Button1" CssClass="button" runat="server" Text="Confirm User" OnClick="Button1_Click" />
        </div>
        <center>
            <h1>Confirmed Users</h1>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id">
                <Columns>
                    <asp:TemplateField HeaderText="Serial No.">
                    <ItemTemplate>
                        <%# Container.DataItemIndex +1 %>
                    </ItemTemplate>
                </asp:TemplateField>
                    <asp:BoundField DataField="username" HeaderText="User Name" />
                    <asp:BoundField DataField="role" HeaderText="Role" />
                    <asp:BoundField DataField="status" HeaderText="Status" />
                </Columns>
            </asp:GridView>
            </center>
        </div>
</asp:Content>
