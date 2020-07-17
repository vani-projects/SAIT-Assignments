<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CPRG214.Marina.App.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <h3>Login</h3>
    <div class="col-md-4">
        <table class="table">
            <tr>
                <td>First Name:</td>
                <td>
                    <asp:TextBox ID="txtFName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Last Name</td>
                <td>
                     <asp:TextBox ID="txtLName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>               
                <td >
                    <asp:Button ID="btnAuthenticate" runat="server" Text="Login" OnClick="btnAuthenticate_Click" />
                </td>
                <td>
                    <asp:Button ID="btnRegister" runat="server" Text="Create An Account" OnClick="btnRegister_Click" />
                </td>
            </tr>
             <tr>
               
                <td colspan="2">
                    <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
