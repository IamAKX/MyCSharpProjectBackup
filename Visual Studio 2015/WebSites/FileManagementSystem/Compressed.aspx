<%@ Page Title="" Language="C#" MasterPageFile="~/Files.master" AutoEventWireup="true" CodeFile="Compressed.aspx.cs" Inherits="Compressed" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .newStyle3 {
        font-family: "buxton Sketch";
        font-size: 35px;
        font-weight: bold;
    }
    .auto-style17 {
        text-align: center;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3 class="auto-style17"><span class="newStyle3">Compressed</span></h3>
<p>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</p>
</asp:Content>

