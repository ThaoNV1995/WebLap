<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EditAccount.ascx.cs" Inherits="WebLap.AdminCP.Controls.EditAccount" %>
<div class="control-edit">
    UseName:<br />
    <asp:TextBox ID="txtUser" runat="server"></asp:TextBox><br />
    Password:<br />
    <asp:TextBox ID="txtPass" runat="server"></asp:TextBox><br />
    <asp:Button ID="btnAdd" runat="server" Text="Update" OnClick="btnAdd_Click" />
</div>