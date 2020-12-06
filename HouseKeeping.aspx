<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HouseKeeping.aspx.cs" Inherits="Lab6Q1.HouseKeeping" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Choose a staff id:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="lstID" runat="server" AutoPostBack="true" OnSelectedIndexChanged="lstID_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <asp:Label ID="lblInfo" runat="server"></asp:Label>
            <br />
            <asp:ListBox ID="lstCity" runat="server">
                <asp:ListItem>Buxar</asp:ListItem>
                <asp:ListItem>Gurugram</asp:ListItem>
                <asp:ListItem>Udupi</asp:ListItem>
            </asp:ListBox>
            <br />
            <asp:Button ID="btnUpdate" OnClick="btnUpdate_Click" runat="server" Text="Update" />
        </div>
    </form>
</body>
</html>
