<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
    <div>
    
        <h1>AJAX Example</h1>
        <p>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        </p>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div class="auto-style1">
                    <asp:TextBox ID="TextBox1" runat="server" placeholder="First Number"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="TextBox2" runat="server" placeholder="Second Number"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="TextBox3" runat="server"  placeholder="Result"></asp:TextBox>
                    <br />
                    <br />
                    <br />
                    <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                        <ProgressTemplate>
                            Adding number... Wait...
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                    <br />
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ADD" />
                    <br />
                    <br />
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
            <asp:Button ID="Button2" runat="server" Text="ADD(without ajax)" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
