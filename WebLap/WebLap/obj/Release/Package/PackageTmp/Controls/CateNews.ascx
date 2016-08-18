<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CateNews.ascx.cs" Inherits="WebLap.Controls.CateNews" %>
<div id="control-cateNews">
    <div class="control-content">
        <asp:Repeater ID="rptContent" runat="server" OnItemDataBound="rptContent_ItemDataBound">
            <ItemTemplate>
                <div class="trol-con">
                    <div class="control-Title">
                        <h1><%#Eval("CateName") %></h1>
                    </div>
                    <asp:HiddenField ID="HiddenField1" Value='<%#Eval("CateID") %>' runat="server" />
                    <div class="control-img">
                        <asp:Image ID="Image" runat="server" />
                    </div>
                    <div class="control-title">
                        <asp:Label ID="lblTitle" runat="server"></asp:Label>
                        <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>
                    </div>
                    <div class="control-subTitle">
                        <asp:Label ID="lblSubTitle" runat="server"></asp:Label>
                    </div>
                    <div class="clear"></div>
                    <asp:Repeater ID="rptCon" runat="server">
                        <ItemTemplate>
                            <div class="control-content">
                                <ul>
                                    <li>
                                        <a href='NewsDetail.aspx?nid=<%#Eval("NewsID") %>'><%#Eval("Title") %> </a>
                                    </li>
                                </ul>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
                <div class="clear"></div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</div>
