<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Multiview in ASP.NET</h1>
    
    </div>
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server" OnActivate="Page_Load">
                <h4>STEP 1</h4>
                <br />
                Enter Your name:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" CommandName="NextView" OnClick="Button1_Click" Text="Next" />
            </asp:View>
            <asp:View ID="View2" runat="server">
                <h4>STEP 2<br /> </h4>
                Enter your course:
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button2" runat="server" CommandName="NextView" OnCommand="NextView" Text="Next" />
            </asp:View>
            <asp:View ID="View3" runat="server">
                <h4>STEP 3</h4>
                <br />
                Enter your Stream :
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button3" runat="server" CommandName="NextView" OnClick="Button3_Click" OnCommand="NextView" Text="Next" />
            </asp:View>
            <asp:View ID="View4" runat="server" OnActivate="View4_Activate">
                <br />
                Name :
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                <br />
                Course:
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                <br />
                Stream:
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </asp:View>
        </asp:MultiView>
    </form>
</body>
</html>
