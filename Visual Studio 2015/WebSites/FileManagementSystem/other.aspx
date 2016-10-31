<%@ Page Title="" Language="C#" MasterPageFile="~/Files.master" AutoEventWireup="true" CodeFile="other.aspx.cs" Inherits="other" %>

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
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3 class="auto-style15"><span class="newStyle3">Others</span></h3>
<p class="auto-style15">
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</p>
</asp:Content>

