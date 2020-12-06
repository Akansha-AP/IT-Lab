<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModifyPrice.aspx.cs" Inherits="Lab6Q3.ModifyPrice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstItems" runat="server" OnSelectedIndexChanged="lstItems_SelectedIndexChanged" AutoPostBack="true"></asp:ListBox>
            <br />
            <asp:Label ID="lblInfo" runat="server"></asp:Label>
            <br />
            Enter new price:<asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
        </div>
    </form>
</body>
</html>
