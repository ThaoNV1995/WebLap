<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListNews.aspx.cs" Inherits="WebLap.ListNews" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="control-content">
        <asp:DataList ID="DataList" runat="server" DataKeyField="NewsID" HorizontalAlign="Justify" RepeatColumns="2" RepeatDirection="Horizontal" RepeatLayout="Table">
            <ItemTemplate>
                <div class="data">
                    <div class="data-img">
                        <asp:Image ID="Image1" runat="server" Height="100px" ImageUrl='<%# Eval("Image") %>' Width="100px" />
                    </div>
                    <%-- <br />--%>
                    <div class="data-tail">
                        &nbsp;<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("NewsID", "NewsDetail.aspx?nid={0}") %>' Text='<%# Eval("Title") %>'></asp:HyperLink>
                        <%-- <br />--%>
                    </div>
                    <div class="data-subtilte">
                        &nbsp;<asp:Label ID="SubTilteLabel" runat="server" Text='<%# Eval("SubTilte") %>' />
                        <%-- <br />--%>
                    </div>
                    <%-- <br />--%>
                </div>
                <div class="clear"></div>

            </ItemTemplate>
        </asp:DataList>
        <div id="paging">
            <asp:Literal ID="paging" runat="server"></asp:Literal>
            <asp:TextBox ID="txtPage" runat="server" Width="75px"></asp:TextBox>
            <asp:Button ID="btGo" runat="server" Text="Go" OnClick="btGo_Click" />
        </div>
    </div>
</asp:Content>
