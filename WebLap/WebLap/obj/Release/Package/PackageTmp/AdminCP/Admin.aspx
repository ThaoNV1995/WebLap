<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="WebLap.AdminCP.Admin2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles/Admin.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id="menu-account">

                <asp:Repeater ID="rptMenu" runat="server" OnItemDataBound="rptMenu_ItemDataBound">
                    <ItemTemplate>
                        <div id="banner-account">
                            <span><%#Eval("MenuName") %></span>
                        </div>
                        <asp:HiddenField ID="hfMenuID" Value='<%#Eval("MenuID") %>' runat="server" />
                        <asp:DataList ID="prtdtList" runat="server" HorizontalAlign="Justify" RepeatColumns="4" RepeatDirection="Horizontal" RepeatLayout="Table">
                            <ItemTemplate>
                                <div id="menu-content">
                                    <div class="menu-icon">
                                        <a href='<%#Eval("MenuDo") %>'>
                                            <asp:Image ID="icon" ImageUrl='<%#Eval("MenuIcon") %>' runat="server" Height="100px" Width="100px" /></a>
                                    </div>
                                    <div class="menu-child">
                                        <a href='<%#Eval("MenuDo") %>'><%#Eval("MenuName") %></a>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:DataList>

                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </form>
</body>
</html>
