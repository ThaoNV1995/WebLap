<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HotNews.ascx.cs" Inherits="WebLap.Controls.HotNews" %>

<div id="content-rigth">
    <ul>
        <asp:Repeater ID="rptNews" runat="server">
            <ItemTemplate>
                <asp:HiddenField ID="hdCount" runat="server" />
                <li><a href='NewsDetail.aspx?nid=<%#Eval("NewsID") %>' onclick="click"><%#Eval("Title") %> (<%#Eval("HiCount") %>)</a></li>
            </ItemTemplate>
        </asp:Repeater>
    </ul>
</div>
