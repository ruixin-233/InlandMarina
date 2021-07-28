<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Registration.ascx.cs" Inherits="MarinaGUI.Controls.Registration" %>

<asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="0" OnFinishButtonClick="Wizard1_FinishButtonClick">
    <WizardSteps>
        <asp:WizardStep ID="WizardStep1" runat="server" Title="Student Profile">
            <table class="table">
                <tr>
                    <td style="width: 150px">First Name:</td>
                    <td><asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Last Name:</td>
                    <td><asp:TextBox ID="txtLastName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Phone:</td>
                    <td><asp:TextBox ID="txtPhone" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>City:</td>
                    <td><asp:TextBox ID="txtCity" runat="server"></asp:TextBox></td>
                </tr>
            </table>
        </asp:WizardStep>
        <asp:WizardStep ID="WizardStep2" runat="server" Title="Security Credentials">
            <table class="table">
                <tr>
                    <td style="width: 150px">Username(First Name): </td>
                    <td><asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Password(Last Name): </td>
                    <td><asp:TextBox ID="txtPassword" runat="server"></asp:TextBox></td>
                </tr>
            </table>
        </asp:WizardStep>
    </WizardSteps>
</asp:Wizard>
