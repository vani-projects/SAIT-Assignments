<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LeaseSlip.aspx.cs" Inherits="CPRG214.Marina.App.Secure.LeaseSlip" %>


<%@ Register Src="~/Controls/DockSlipControl.ascx" TagPrefix="uc1" TagName="DockSlipControl" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <h3>Lease Slip</h3>
    <div>
        <table>

            <tr>
                <td>
                    <uc1:DockSlipControl runat="server" ID="DockSlipControl" />
                </td>
            </tr>
            <tr>
                <td>
                      <asp:Button ID="btnLease" runat="server" Text="Lease" OnClick="btnLease_Click" />
                </td>
                <td>

                    <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
                    <asp:GridView ID="gvLeasedSlips" runat="server"></asp:GridView>
                </td>                
            </tr>
            </table>
    </div>
</asp:Content>
