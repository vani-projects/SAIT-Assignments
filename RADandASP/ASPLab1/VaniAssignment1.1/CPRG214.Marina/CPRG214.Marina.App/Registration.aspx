<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="CPRG214.Marina.App.Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <h3>Registraion</h3>
    <div>
        <table class="table">
            <tr>
                <td>First Name</td>
                <td>
                    <asp:TextBox ID="txtFName" runat="server"></asp:TextBox>

                    <asp:RequiredFieldValidator ID="rfvFName" runat="server" ErrorMessage="Fisrt name is required" ControlToValidate="txtFName" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Last Name</td>
                <td>
                    <asp:TextBox ID="txtLName" runat="server"></asp:TextBox>

                    <asp:RequiredFieldValidator ID="rfvLName" runat="server" ErrorMessage="Last name is required" ControlToValidate="txtLName" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Phone</td>
                <td>
                    <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>

                    <asp:RegularExpressionValidator ID="regPhone" runat="server" ErrorMessage="Phone should be in 123-123-1234 pattern" ControlToValidate="txtPhone"
                        ForeColor="Red" ValidationExpression="[0-9]{3}-[0-9]{3}-[0-9]{4}">*</asp:RegularExpressionValidator>

                </td>
            </tr>
            <tr>
                <td>City</td>
                <td>
                    <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Button ID="btnRegister" runat="server" Text="Submit" OnClick="btnRegister_Click" />
                </td>
            </tr>

        </table>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />

    </div>

</asp:Content>
