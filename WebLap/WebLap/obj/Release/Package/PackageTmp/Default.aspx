<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebLap.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="control-content">
        <asp:Repeater ID="rptNewhot" runat="server">
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
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
