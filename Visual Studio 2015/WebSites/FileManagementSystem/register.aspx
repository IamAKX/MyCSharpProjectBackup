<%@ Page Title="" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>
    <br />
    <span style="font-size: xx-large">Registration Form</span></h3>
<p>
    &nbsp;</p>
<p style="text-align: left; margin-left: 200px">
    <asp:TextBox ID="TextBox1" runat="server" Width="213px" Font-Bold="False" Font-Italic="True" Font-Names="Buxton Sketch" Font-Size="Medium" ForeColor="Black" placeholder="User Name"></asp:TextBox>
    <em>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*User Name" ForeColor="Red" style="font-size: small"></asp:RequiredFieldValidator>
    </em>
</p>
<p style="text-align: left; margin-left: 200px">
    <asp:TextBox ID="TextBox2" runat="server" Width="213px" Font-Italic="True" Font-Names="Buxton Sketch" Font-Size="Medium" ForeColor="Black" placeholder="e-Mail"></asp:TextBox>
    <em>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="*e-Mail" ForeColor="Red" style="font-size: small"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="*Not a valid e-Mail" ForeColor="Red" style="font-size: small" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
    </em>
</p>
<p style="text-align: left; margin-left: 200px">
    <asp:TextBox ID="TextBox3" runat="server" Width="214px" Font-Italic="True" Font-Names="Buxton Sketch" Font-Size="Medium" ForeColor="Black" placeholder="Password" TextMode="Password"></asp:TextBox>
    <em>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="*Password" ForeColor="Red" style="font-size: small"></asp:RequiredFieldValidator>
    </em>
</p>
<p style="text-align: left; margin-left: 200px">
    <asp:TextBox ID="TextBox4" runat="server" Width="218px" Font-Italic="True" Font-Names="Buxton Sketch" Font-Size="Medium" ForeColor="Black" placeholder="Confirm Password" TextMode="Password"></asp:TextBox>
    <em>
    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox3" ControlToValidate="TextBox4" ErrorMessage="*Enter same password" ForeColor="Red" style="font-size: small"></asp:CompareValidator>
    </em>
</p>
<p>
    <asp:Button ID="Button1" runat="server" Text="Register" Font-Bold="True" Font-Names="Buxton Sketch" Font-Size="Large" OnClick="Button1_Click" />
</p>
    <p>
        <asp:HyperLink ID="HyperLink1" runat="server" Font-Names="Buxton Sketch" Font-Underline="False" NavigateUrl="~/Default.aspx">Back to Login</asp:HyperLink>
</p>
</asp:Content>

