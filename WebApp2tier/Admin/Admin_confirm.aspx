<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Admin_confirm.aspx.cs" Inherits="WebApplication.Admin.Admin_confirm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div><link rel="stylesheet" type="text/css" href="Admin.css" />
        <br />
        <div>
            <asp:Button ID="Button1" CssClass="button" runat="server" Text="Confirmed User" OnClick="Button1_Click" />
        </div>
        <center>
            <h1>Registered Users</h1>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" OnRowDeleting="GridView1_RowDeleting" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
                <Columns>
                    <asp:TemplateField HeaderText="Serial No.">
                    <ItemTemplate>
                        <%# Container.DataItemIndex +1 %>
                    </ItemTemplate>
                </asp:TemplateField>
                    <asp:BoundField DataField="username" HeaderText="User Name" />
                    <asp:BoundField DataField="role" HeaderText="Role" />
                    <asp:BoundField DataField="status" HeaderText="Status" />
                    <asp:CommandField CancelText="Block" EditText="Approve" HeaderText="Approve" ShowEditButton="True" UpdateText="Confirm" />
                </Columns>
            </asp:GridView>
            </center>
        </div>
</asp:Content>
