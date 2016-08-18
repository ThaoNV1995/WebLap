<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebLap.AdminCP.Admin1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles/MasterAdmin.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <div id="header" style="height: 100px;">
                    <img src="../Images/SlideShow/Panner.png" />

                </div>
                <div id="menu">
                    <ul>
                        <asp:Repeater ID="rptParent" runat="server">
                            <ItemTemplate>
                                <li><a href='Default.aspx?id=<%#Eval("MenuID") %>'><%#Eval("MenuName") %></a> </li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
                <div id="clear"></div>
                <div id="main">
                    <div id="left">
                        <ul>
                            <asp:Repeater ID="rptChild" runat="server">
                                <ItemTemplate>
                                    <li><a href="Default.aspx?id=<%# Eval("MenuParentID") %>&do=<%# Eval("MenuDo") %>"><%#Eval("MenuName") %></a> </li>
                                </ItemTemplate>
                            </asp:Repeater>
                        </ul>
                    </div>
                    <div id="content">
                        <asp:PlaceHolder ID="phContent" runat="server"></asp:PlaceHolder>
                        <div id="clear"></div>
                    </div>

                </div>
                <div id="footer">
                    <center>
            <div id="nav">
                <span>Bản quyền thuộc về trung tâm phát triển phần mềm SEVN</span>
            </div>
            <div id="copyright">
                <span>Địa chỉ: Mỹ Hào - Hưng Yên</span>
            </div>
                </center>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
