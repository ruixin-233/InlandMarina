<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateRegistration.aspx.cs" Inherits="MarinaGUI.Secure.UpdateRegistration" %>

<%@ Register Src="~/Controls/Registration.ascx" TagPrefix="uc1" TagName="Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Update Registration Info</h2>
    <br />
    <uc1:Registration runat="server" ID="uxRegistration" />
</asp:Content>
