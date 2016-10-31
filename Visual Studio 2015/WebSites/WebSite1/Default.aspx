<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>BUDDHAINE</title>
    <link href="Style/MyStyle.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style3 {
            height: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>I am ASP.NET developer</h1>
        <hr />
        <br />
        ASP Rocks!!</div>
    <table  border="1" style="width: 100%; height: 106px;">
        <tr>
            <td class="auto-style1">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Home</asp:HyperLink>
            </td>
            <td class="auto-style1">
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/AboutUs.aspx">About Us</asp:HyperLink>
            </td>
            <td class="auto-style1">
                <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/ContactUs.aspx">Contact Us</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="2" style="text-align: right">
                <img alt="" src="Images/food.png" style="width: 109px; height: 122px; text-align: center" /></td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td colspan="3" style="text-align: center">Copyright 2015 AkashTech</td>
        </tr>
    </table>
    </form>
    </body>
</html>

