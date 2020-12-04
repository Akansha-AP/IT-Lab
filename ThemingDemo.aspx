<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThemingDemo.aspx.cs" Inherits="Lab5Q3.ThemingDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="pnl" runat="server" Height="300px">
            <asp:Label ID="Label1" runat="server" Text="Select a theme:"></asp:Label>
            <asp:DropDownList ID="DropDownList1" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" runat="server">
            </asp:DropDownList>
                </asp:Panel>
            
        </div>
    </form>
</body>
</html>
