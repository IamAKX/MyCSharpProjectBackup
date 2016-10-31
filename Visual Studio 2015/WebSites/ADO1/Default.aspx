<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            text-align: right;
            width: 266px;
        }
        .auto-style3 {
            width: 261px;
        }
        .auto-style4 {
            text-align: right;
            width: 266px;
            height: 34px;
        }
        .auto-style5 {
            width: 261px;
            height: 34px;
        }
        .auto-style6 {
            height: 34px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <h1>Student Management</h1>
    
    </div>
        <table style="width: 100%; text-align: center;">
            <tr>
                <td class="auto-style2">Roll : </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server" Width="196px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Name : </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox2" runat="server" Width="194px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Course : </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox3" runat="server" Width="190px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style5">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
                &nbsp;
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Delete" />
                &nbsp;
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Display"  />
                &nbsp;
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Update" />
                </td>
                <td class="auto-style6"></td>
            </tr>
        </table>
    </form>
</body>
</html>
