<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetail.aspx.cs" Inherits="WebLap.ProductDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="new-content">
        <asp:Repeater ID="rptProDe" runat="server">
            <ItemTemplate>
                <div class="new-title">
                    <h2><a href='ProductDetail.aspx?nid=<%#Eval("NewsID") %>'><%#Eval("Title") %> </a></h2>
                </div>
                <div class="new-img">
                    <center>
                     <img src='<%#Eval("Image") %>' alt="Alternate Text"/> 
                        </center>
                </div>
                <div class="new-detitle">
                    <span><%#Eval("Detail") %></span>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
