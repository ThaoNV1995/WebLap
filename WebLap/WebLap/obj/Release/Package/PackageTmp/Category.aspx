<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Category.aspx.cs" Inherits="WebLap.Category1" %>

<%@ Register Src="~/Controls/CateNews.ascx" TagPrefix="uc1" TagName="CateNews" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:CateNews runat="server" ID="CateNews" />
   
</asp:Content>
