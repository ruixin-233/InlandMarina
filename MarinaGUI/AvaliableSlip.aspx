<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AvaliableSlip.aspx.cs" Inherits="MarinaGUI.AvaliableSlip" %>

<%@ Register Src="~/Controls/DockSelector.ascx" TagPrefix="uc1" TagName="DockSelector" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <h2>Check Avaliable Slips</h2>
    <br />
    <asp:Label ID="lblDock1" runat="server" Text="Pick a Dock: "></asp:Label>
    <uc1:DockSelector runat="server" id="DockSelector" /> 
    <br />
    <br />
    <asp:Label ID="lblDock2" runat="server" Text="Avaliable Slips: "></asp:Label>
    <br />
    <asp:ListBox ID="lstSlips" runat="server" Height="195px" Width="130px"></asp:ListBox>

    

</asp:Content>

