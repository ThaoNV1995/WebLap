<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="WebLap.Product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="rptProcduct" runat="server" OnItemDataBound="rptProcduct_ItemDataBound">
        <ItemTemplate>
            <div class="product-content">
                <h2><%#Eval("CateName") %></h2>
                <asp:HiddenField ID="Hidden" Value='<%#Eval("CateID") %>' runat="server" />
                <div class="pro">
                    <asp:Repeater ID="rptContent" runat="server">
                        <ItemTemplate>
                            <div class="retu">
                                <div class="pro-title">
                                    <a href='ProductDetail.aspx?nid=<%#Eval("NewsID") %>'><%#Eval("Title") %> </a>
                                </div>
                                <div class="pro-img">
                                    <a href='ProductDetail.aspx?nid=<%#Eval("NewsID") %>'>
                                        <img src='<%#Eval("Image") %>' alt="Alternate Text" />
                                    </a>
                                </div>
                                
                                <div class="pro-subtitle">
                                    <%#Eval("SubTilte") %>
                                </div>
                                <div class="clear"></div>
                            </div>
                            <hr/>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
