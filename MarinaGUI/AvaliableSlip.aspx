<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AvaliableSlip.aspx.cs" Inherits="MarinaGUI.AvaliableSlip" %>

<%@ Register Src="~/Controls/DockSelector.ascx" TagPrefix="uc1" TagName="DockSelector" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <h2>Avaliable slips</h2>
    <uc1:DockSelector runat="server" id="DockSelector" /> <br />

    <asp:ListBox ID="lstSlips" runat="server"></asp:ListBox>

</asp:Content>

