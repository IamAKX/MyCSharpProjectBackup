<%@ Page Title="" Language="C#" MasterPageFile="~/Files.master" AutoEventWireup="true" CodeFile="allfiles.aspx.cs" Inherits="allfiles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style15 {
            text-align: center;
        }
        .newStyle3 {
            font-family: "Buxton Sketch";
            font-size: 35px;
            font-style: normal;
            font-weight: bold;
        }
        .auto-style16 {
            margin-left: 28px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3 class="auto-style15">&nbsp;<span class="newStyle3">All Files</span></h3>
    <p class="auto-style15">
        <asp:GridView ID="GridView1" runat="server" CssClass="auto-style16" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="GridView1_RowCommand">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="DeleteBtn" Text="Delete">
                <ControlStyle BackColor="Red" Font-Names="Buxton Sketch" ForeColor="White" />
                <ItemStyle BackColor="White" Font-Names="Buxton Sketch" ForeColor="White" />
                </asp:ButtonField>
                <asp:ButtonField ButtonType="Button" CommandName="DownloadBtn" Text="Download">
                <ControlStyle BackColor="#00CC00" ForeColor="White" />
                <ItemStyle BackColor="White" Font-Names="Buxton Sketch" ForeColor="White" />
                </asp:ButtonField>
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </p>
</asp:Content>

