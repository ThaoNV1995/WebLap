<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddNews.ascx.cs" Inherits="WebLap.AdminCP.Control.AddNews" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<div id="addnews">
    Chọn chuyên mục:
    <br />
    <asp:DropDownList ID="ddlCate" runat="server">
    </asp:DropDownList>
    <br />
    Tiêu đề:<br />
    <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox><br />
    Phụ đề:<br />
    <asp:TextBox ID="txtSubTile" runat="server"></asp:TextBox><br />
    Nội dung:<br />
    <CKEditor:CKEditorControl ID="txtContent" runat="server" FilebrowserBrowseUrl="../ckfinder_aspnet_2.5.0.1/ckfinder/ckfinder.html" FilebrowserFlashBrowseUrl="../ckfinder_aspnet_2.5.0.1/ckfinder/ckfinder.html" FilebrowserFlashUploadUrl="../ckfinder_aspnet_2.5.0.1/ckfinder/ckfinder.html" FilebrowserImageBrowseLinkUrl="../ckfinder_aspnet_2.5.0.1/ckfinder/ckfinder.html" FilebrowserImageBrowseUrl="../ckfinder_aspnet_2.5.0.1/ckfinder/ckfinder.html" FilebrowserImageUploadUrl="../ckfinder_aspnet_2.5.0.1/ckfinder/ckfinder.html" FilebrowserUploadUrl="../ckfinder_aspnet_2.5.0.1/ckfinder/ckfinder.html"></CKEditor:CKEditorControl>
    <br />
    <asp:FileUpload ID="fileImge" runat="server" /><br />
    <asp:Button ID="btnAdd" runat="server" Text="sever" stype="clear:both;" OnClick="btnAdd_Click" />
     <div id="clear"></div>
</div>
