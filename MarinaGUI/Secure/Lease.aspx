<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lease.aspx.cs" Inherits="MarinaGUI.Secure.Lease" %>

<%@ Register Src="~/Controls/DockSelector.ascx" TagPrefix="uc1" TagName="DockSelector" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Lease</h2>
    <br />
    <asp:Label ID="lblDock1" runat="server" Text="Select a Dock: "></asp:Label>
    <uc1:DockSelector runat="server" ID="DockSelector" />
    <br />
    <br />
    <asp:Label ID="lblDock2" runat="server" Text="Select a Slip: "></asp:Label>
    <br />
    <asp:ListBox ID="lstSlips" runat="server" Height="195px" Width="130px"></asp:ListBox>

    <asp:Button ID="btnLease" runat="server" Text="Lease" />
</asp:Content>
