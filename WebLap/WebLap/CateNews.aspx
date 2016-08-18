<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CateNews.aspx.cs" Inherits="WebLap.CateNews" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="control-content">
    <asp:Repeater ID="rptPro" runat="server">
        <ItemTemplate>
            <div class="CateNews">
                <img src="<%# Eval("Image") %>" />
                <a href="ProductDetail.aspx?pid=<%#Eval("ProcductID") %>">
                    <h3><%# Eval("Title") %></h3>
                </a>
                
                <span><%#Eval("Description") %></span>
            </div>
            <div class="clear"></div>
        </ItemTemplate>
    </asp:Repeater>
        
    <div id="paging">
        <asp:Literal ID="paging" runat="server"></asp:Literal>
        <asp:TextBox ID="txtPage" runat="server" Width="75px"></asp:TextBox>
        <asp:Button ID="btPage" runat="server" Text="Go" OnClick="btPage_Click" />
    </div>
        </div>
</asp:Content>
