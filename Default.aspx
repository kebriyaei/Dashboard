<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BI._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

           <div class="row">
                <ucTotalSaleCoOptional:TotalSaleCoOptional ID="TotalSaleCoOptional1" runat="server" />
            </div>
</asp:Content>
