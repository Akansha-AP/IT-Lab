<%@ Page Title="" Language="C#" MasterPageFile="~/MobileMaster.Master" AutoEventWireup="true" CodeBehind="firstPage.aspx.cs" Inherits="Lab5Q4.firstPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Select a mobile phone:
    <asp:DropDownList AutoPostBack="true" ID="lstMobile" runat="server" OnSelectedIndexChanged="lstMobile_SelectedIndexChanged">
        <asp:ListItem Text="Samsung"></asp:ListItem>
        <asp:ListItem Text="Apple"></asp:ListItem>
        <asp:ListItem Text="Motorola"></asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Button ID="btnShowDetails" OnClick="btnShowDetails_Click" runat="server" Text="Show Details" />
    <br />
</asp:Content>
