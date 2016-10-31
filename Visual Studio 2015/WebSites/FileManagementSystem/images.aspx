<%@ Page Title="" Language="C#" MasterPageFile="~/Files.master" AutoEventWireup="true" CodeFile="images.aspx.cs" Inherits="images" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style15 {
        text-align: center;
    }
    .newStyle3 {
        font-family: "buxton Sketch";
        font-size: 35px;
        font-weight: bold;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="auto-style15">
    <span class="newStyle3">Images<br />
    <br />
    </span>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
</div>
</asp:Content>

