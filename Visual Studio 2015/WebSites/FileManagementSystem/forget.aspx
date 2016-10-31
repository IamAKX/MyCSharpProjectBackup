<%@ Page Title="" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="forget.aspx.cs" Inherits="forget" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>
    <br />
    <span style="font-size: xx-large">Forget Password</span></h3>
    <p>
        &nbsp;</p>
    <p>
        <asp:TextBox ID="TextBox1" runat="server" Font-Italic="True" Font-Names="Buxton Sketch" Font-Size="Medium" ForeColor="Black" OnTextChanged="TextBox1_TextChanged" Width="204px" placeholder="e-Mail"></asp:TextBox>
    </p>
    <p>
        <asp:TextBox ID="TextBox2" runat="server" Font-Italic="True" Font-Names="Buxton Sketch" Font-Size="Medium" ForeColor="Black" Width="207px" placeholder="User Name"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Names="Buxton Sketch" Font-Size="Medium" Text="Fetch password" OnClick="Button1_Click" />
    </p>
    <p>
        <asp:HyperLink ID="HyperLink1" runat="server" Font-Names="Buxton Sketch" Font-Underline="False" NavigateUrl="~/Default.aspx">Back to login</asp:HyperLink>
    </p>
</asp:Content>

