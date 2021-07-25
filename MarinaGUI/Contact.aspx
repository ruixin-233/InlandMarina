<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="MarinaGUI.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Contact Information: </h3>
    <address>
        Inland Lake Marina<br />
        Box 123<br />
        Inland Lake, Arizona<br />        86038 <br />
    </address>
        
    <address>
        <strong>Manager:</strong> Glenn Cooke<br />
        <strong>Slip Manager:</strong> Kimberley Carson <br />
    </address>

    <address>
        <strong>Office phone:</strong> 928-555-2234 <br />
        <strong>Leasing phone:</strong> 928-555-2235 <br />
        <strong>Fax:</strong> 928-555-2236 <br />
    </address>

    <address>
        <strong>Contact Email:</strong> <a href="info@inlandmarina.com">info@inlandmarina.com</a>
    </address>
</asp:Content>
