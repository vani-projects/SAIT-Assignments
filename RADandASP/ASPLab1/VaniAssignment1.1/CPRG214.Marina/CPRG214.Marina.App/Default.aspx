﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CPRG214.Marina.App._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Inland Marina Limited</h1>
        <p class="lead">Welcome to Inland Marina located on the south shore Inland Lake, just a small commute from major centers in the south west.</p>
        <%--<p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>--%>
    </div>

    <div class="row">
        <div class="col-md-6">
            <h2>About Us</h2>
            <p>
                Inland Marina was established in the 1967 shortly after Inland Lake was created as a result of the South West damn. 
                From its humble beginnings, it has grown to be the largest marina on Inland Lake.  Due to the warm climate that extends
                year round, Inland Lake has become a popular tourist destination in the south west.  Boat owners from California, Arizona,
                Nevada, and Utah are attracted to the area.  Inland Marina has 90 slips ranging in size from 16 to 32 feet in length. 
                Dock services include electrical and fresh water.
            </p>
            <%--<p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>--%>
        </div>
       <%-- <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>--%>
    </div>

</asp:Content>
