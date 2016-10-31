<%@ Page Title="" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>


<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <h3>
    <br />
    <span style="font-size: xx-large">Sign In</span></h3>
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Width="220px" Font-Italic="True" Font-Names="Buxton Sketch" Font-Size="Medium" ForeColor="Black" placeholder="e-Mail"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Enter your e-Mail" Font-Italic="True" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="TextBox2" runat="server" Width="218px" Font-Italic="True" Font-Names="Buxton Sketch" Font-Size="Medium" ForeColor="Black" placeholder="Password" TextMode="Password"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="*Enter your Password" Font-Italic="True" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
<br />
<br />
<asp:Button ID="Button1" runat="server" Text="Log In" Font-Bold="True" Font-Names="Buxton Sketch" Font-Size="Large" OnClick="Button1_Click" />
<br />
<br />
<br />
<br />
<asp:HyperLink ID="HyperLink1" runat="server" Font-Names="Buxton Sketch" Font-Underline="False" NavigateUrl="~/register.aspx">New User? Register here</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<br />
<asp:HyperLink ID="HyperLink2" runat="server" Font-Names="Buxton Sketch" Font-Underline="False" NavigateUrl="~/forget.aspx">Forget Password</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
</asp:Content>


