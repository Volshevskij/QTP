<%@ Page Title="Customers page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="QTProj.Customers" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>CUSTOMERS</h1>
    <div style="margin-top: 10px;">
    <asp:GridView ID="Grid" runat="server"
             AutoGenerateColumns="True" DataKeyNames="CustomerId">
</asp:GridView>
        </div>
</asp:Content>
