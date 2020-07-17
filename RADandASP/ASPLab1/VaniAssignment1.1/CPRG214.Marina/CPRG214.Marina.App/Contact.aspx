<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="CPRG214.Marina.App.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <h3><%: Title %>.</h3>
   
    <address>
        Inland Lake Marina<br />
        Box 123 <br />
        Inland Lake, Arizona<br />
        86038<br /><br />
        <abbr title="Phone"> Office Phone:</abbr>
       928-555-2234
        <br />
        <abbr title="Phone"> Leasing Phone:</abbr>
        928-555-2235
        <br />
         <abbr title="fax"> fax </abbr>
        928-555-2236
        <br />
        <br />
        Manager: Glenn Cooke<br />
        Slip Manager: Kimberley Carson<br /> 

    </address>

    <address>
        
        <strong>Contact email:</strong> <a href="mailto:info@inlandmarina.com">info@inlandmarina.com</a>
    </address>
</asp:Content>
