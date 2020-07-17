<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Docks.aspx.cs" Inherits="CPRG214.Marina.App.Docks" %>

<%--<%@ Register Src="~/Controls/DockSelector.ascx" TagPrefix="uc1" TagName="DockSelector" %>
<%@ Register Src="~/Controls/SlipSelector.ascx" TagPrefix="uc1" TagName="SlipSelector" %>--%>
<%@ Register Src="~/Controls/DockSlipControl.ascx" TagPrefix="uc1" TagName="DockSlipControl" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <hr />
    <h3>Docks</h3>
    <uc1:DockSlipControl runat="server" id="DockSlipControl" />
    <%--<uc1:DockSelector runat="server" id="DockSelector" AllowpostBack="True" />--%>
    
    <br /><br />

  <div class="col-md-7">
       
        <br />
        <asp:LinkButton ID="lBtnLeaseSlip" runat="server" OnClick="lBtnLeaseSlip_Click">Lease Slip</asp:LinkButton>
    </div>
</asp:Content>
