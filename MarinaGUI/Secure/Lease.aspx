<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lease.aspx.cs" Inherits="MarinaGUI.Secure.Lease" %>

<%@ Register Src="~/Controls/DockSelector.ascx" TagPrefix="uc1" TagName="DockSelector" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Lease</h2>
    <br />
    <asp:Label ID="lblDock1" runat="server" Text="Pick a Dock: "></asp:Label>
    <uc1:DockSelector runat="server" id="DockSelector" /> 
    <br />
    <br />
    <asp:Label ID="lblDock2" runat="server" Text="Avaliable Slips: "></asp:Label>
    <br /><br />
<%--    <asp:ListBox ID="lstSlips" runat="server" Height="195px" Width="130px"></asp:ListBox>--%>

    <div class="gridView">
        <asp:GridView ID="gvSlips" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
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
    </div>
    <br />
    <asp:Button ID="btnLease" runat="server" Text="Lease" class="btn btn-outline-info" />
</asp:Content>
