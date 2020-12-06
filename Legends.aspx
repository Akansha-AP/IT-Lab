<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Legends.aspx.cs" Inherits="Lab6Q2.Legends" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Choose the Genre:
            <asp:DropDownList ID="lstGenre" runat="server" OnSelectedIndexChanged="lstGenre_SelectedIndexChanged" AutoPostBack="true">
            </asp:DropDownList>
            <br />
            <asp:ListBox ID="lstLegends" OnSelectedIndexChanged="lstLegends_SelectedIndexChanged" AutoPostBack="true" runat="server" Height="91px" Width="100px"></asp:ListBox>
            <br />
            <br />
            <br />
            <asp:Label ID="lblInfo" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
