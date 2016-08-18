<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebLap.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles/Register.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="body">
            <center>
             <p>Đăng ký tài khoản Blog tại đây</p>
        </center>
            <hr>
            <div id="register">
                <center>
        <asp:TextBox ID="txtUserName" runat="server" placeholder="UseName"></asp:TextBox>
        <asp:TextBox ID="txtPass" TextMode="Password" runat="server" placeholder="PassWord"></asp:TextBox>
        <asp:TextBox ID="txtRePass" TextMode="Password" runat="server" placeholder="RePassWord"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
                </center>
            </div>

        </div>
    </form>
</body>
</html>
