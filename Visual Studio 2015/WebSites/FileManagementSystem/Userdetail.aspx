<%@ Page Title="" Language="C#" MasterPageFile="~/Files.master" AutoEventWireup="true" CodeFile="Userdetail.aspx.cs" Inherits="Userdetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .newStyle3 {
        font-family: "buxton Sketch";
        font-size: 35px;
        font-weight: bold;
    }
    .auto-style15 {
        text-align: center;
    }
    .auto-style16 {
        width: 50%;
        margin-left: 257px;
        margin-top: 52px;
    }
    .auto-style17 {
        text-align: right;
        width: 207px;
        font-size: large;
    }
    .auto-style18 {
        margin-left: 80px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p class="auto-style15">
    <span class="newStyle3">Details</span></p>
<p class="auto-style15">
    <table align="center" class="auto-style16">
        <tr>
            <td class="auto-style17"><strong>Image Files&nbsp; :&nbsp; </strong></td>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style17"><strong>Audio Files&nbsp; :&nbsp; </strong></td>
            <td class="auto-style18">
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style17"><strong>Videos Files&nbsp; :</strong></td>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style17"><strong>Compressed Files&nbsp; :</strong></td>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style17"><strong>Other Files&nbsp; :</strong></td>
            <td>
                <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style17"><strong>Trashed files&nbsp; :</strong></td>
            <td>
                <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style17"><strong>Total Space Occupies&nbsp; : </strong></td>
            <td>
                <asp:Label ID="Label13" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>
</p>
</asp:Content>

