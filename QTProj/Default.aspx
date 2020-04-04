<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="QTProj._Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        
    </div>
    <asp:GridView ID="Grid" runat="server"
             AutoGenerateColumns="True" DataKeyNames="CustomerId">
</asp:GridView>
</asp:Content>