<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AvaliableSlip.aspx.cs" Inherits="MarinaGUI.AvaliableSlip" %>

<%@ Register Src="~/Controls/DockSelector.ascx" TagPrefix="uc1" TagName="DockSelector" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <h2>Avaliable Slips</h2>
    <br />
    <uc1:DockSelector runat="server" id="DockSelector" /> 
    <br />
    <br />
    <asp:ListBox ID="lstSlips" runat="server" Height="195px" Width="130px"></asp:ListBox>

    <asp:Label ID="lblDock" runat="server" Text=""></asp:Label>

</asp:Content>

