<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DockSlipControl.ascx.cs" Inherits="CPRG214.Marina.App.Controls.DockSlipControl" %>


<br />
<table class="table">
    <tr>
        <td>
            <asp:DropDownList ID="dockList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dockList_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>Name
        </td>
        <td>
            <asp:Label ID="lblDockName" runat="server" Text=""></asp:Label>
        </td>
    </tr>
    <tr>
        <td>Water Service
        </td>
        <td>
            <asp:Label ID="lblWaterService" runat="server" Text=""></asp:Label>
        </td>
    </tr>
    <tr>
        <td>Electrical Service
        </td>
        <td>
            <asp:Label ID="lblEService" runat="server" Text=""></asp:Label>
        </td>
    </tr>
    <tr>
        <td>Available Slips
        </td>
        <td>
            <asp:DropDownList ID="slipList" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
</table>




