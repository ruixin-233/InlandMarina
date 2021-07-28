<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="MarinaGUI.Registration" %>

<%@ Register Src="~/Controls/Registration.ascx" TagPrefix="uc1" TagName="Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Registration</h2>
    <br />
    <uc1:Registration runat="server" id="uxRegistration" />
    <br />
    <p>Already have an account? Click <a href="/Login">here</a> to login</p>
</asp:Content>
