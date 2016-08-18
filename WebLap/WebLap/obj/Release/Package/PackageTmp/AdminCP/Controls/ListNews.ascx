<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ListNews.ascx.cs" Inherits="WebLap.AdminCP.Controls.ListNews" %>
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="NewsID" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowCommand="GridView1_OnRowCommand">
    <AlternatingRowStyle BackColor="#DCDCDC" />
    <Columns>
        <asp:TemplateField HeaderText="NewsID">
            <ItemTemplate>
                <p><%#Eval("NewsID") %></p>
            </ItemTemplate> 
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Image">
            <ItemTemplate>
                <img width="100" src="<%#Eval("Image") %>"/>
            </ItemTemplate> 
        </asp:TemplateField>
         <asp:TemplateField HeaderText="Title">
            <ItemTemplate>
                <p><%#Eval("Title") %></p>
            </ItemTemplate> 
        </asp:TemplateField>
         <asp:TemplateField HeaderText="SubTilte">
            <ItemTemplate>
                <p><%#Eval("SubTilte") %></p>
            </ItemTemplate> 
        </asp:TemplateField>
         <asp:TemplateField HeaderText="Detail">
            <ItemTemplate>
                <p style="width: 400px"><%#Eval("Detail") %></p>
            </ItemTemplate> 
        </asp:TemplateField>
        <asp:HyperLinkField DataNavigateUrlFields="NewsID" DataNavigateUrlFormatString="../Default.aspx?id={0}&do=editnews" Text="Edit" HeaderText="Edit" />
        <asp:TemplateField HeaderText="Delete">
            <ItemTemplate>
                <asp:LinkButton runat="server" ID="lnkView" CommandArgument='<%#Eval("NewsID") %>'>Delete</asp:LinkButton>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>

    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
    <SortedAscendingCellStyle BackColor="#F1F1F1" />
    <SortedAscendingHeaderStyle BackColor="#0000A9" />
    <SortedDescendingCellStyle BackColor="#CAC9C9" />
    <SortedDescendingHeaderStyle BackColor="#000065" />

</asp:GridView>
<div id="paging">
    <asp:Literal ID="paging" runat="server"></asp:Literal>
</div>
