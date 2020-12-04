<%@ Page Title="" Language="C#" MasterPageFile="~/MobileMaster.Master" AutoEventWireup="true" CodeBehind="secondPage.aspx.cs" Inherits="Lab5Q4.secondPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblInfo" runat="server"></asp:Label>
    <br />
    <br />
    <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
</asp:Content>
