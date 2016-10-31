<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ContactUs.aspx.cs" Inherits="ContactUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <h1>Budduaine's Cafe</h1>
        <asp:BulletedList ID="BulletedList1" runat="server" BackColor="#FF9933" BorderColor="#CC3300" BulletStyle="Disc" OnClick="BulletedList1_Click">
            <asp:ListItem>Tea</asp:ListItem>
            <asp:ListItem>Coffee</asp:ListItem>
            <asp:ListItem>Choci</asp:ListItem>
            <asp:ListItem>Ice Cream</asp:ListItem>
        </asp:BulletedList>
    </form>
    <table style="width:100%;">
        <tr>
            <td rowspan="4">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2"></td>
            <td></td>
        </tr>
    </table>
</body>
</html>
