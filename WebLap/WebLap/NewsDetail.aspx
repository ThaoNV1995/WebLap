<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewsDetail.aspx.cs" Inherits="WebLap.NewsDetail" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="new-content">
        <asp:Repeater ID="rptDetai" runat="server">
            <ItemTemplate>
                <div class="new-title">
                    <a href="#"><%#Eval("Title") %></a>
                </div>
                <div class="new-img">
                    <center>
                    <img src='<%#Eval("Image") %>' alt="Alternate Text" />
                        </center>
                </div>
            </ItemTemplate>
        </asp:Repeater>
        <div class="new-detitle">
            <asp:Label ID="rptnew" runat="server">

                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </asp:Label>
        </div>
    </div>
</asp:Content>
