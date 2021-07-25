<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="MarinaGUI.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Registration</h2>
    <table class="table">
        <tr>
            <td>First Name: </td>
            <td><asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
            <td></td>
        </tr>
        <tr>
            <td>Last Name: </td>
            <td><asp:TextBox ID="txtPassword" runat="server"></asp:TextBox></td>
            <td></td>
        </tr>
        <tr>
            <td>Phone #: </td>
            <td><asp:TextBox ID="txtPhone" runat="server"></asp:TextBox></td>
            <td></td>
        </tr>
        <tr>
            <td>City: </td>
            <td><asp:TextBox ID="txtCity" runat="server"></asp:TextBox></td>
            <td></td>
        </tr>
    </table>

</asp:Content>
