<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="QTProj._Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>DATA</h1>
    <div style="margin-top: 10px;">
        <asp:GridView ID="Grid" runat="server"
             AutoGenerateColumns="True" >
</asp:GridView>
    </div>   
</asp:Content>