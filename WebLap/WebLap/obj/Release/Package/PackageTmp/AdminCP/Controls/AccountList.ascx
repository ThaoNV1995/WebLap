<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AccountList.ascx.cs" Inherits="WebLap.AdminCP.Controls.AccountList" %>
<asp:GridView ID="Account" runat="server" OnSelectedIndexChanged="Account_SelectedIndexChanged">
   <%--  <AlternatingRowStyle BackColor="#DCDCDC" />
    <Columns>
        <asp:TemplateField HeaderText="UserName">
            <ItemTemplate>
                <p><%#Eval("UserName") %></p>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Password">
            <ItemTemplate>
                <p><%#Eval("Password") %></p>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>--%>

</asp:GridView>
