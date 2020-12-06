<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeInfo.aspx.cs" Inherits="Lab6Q4.EmployeeInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Insert data into Works:<br />
            Person Name:<asp:TextBox ID="txtPerson" runat="server"></asp:TextBox>
            <br />
            Company Name:<asp:TextBox ID="txtCompany" runat="server"></asp:TextBox>
            <br />
            Salary:<asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnInsert" OnClick="btnInsert_Click" runat="server" Text="Insert" />
            <br />
            <asp:Label ID="lblInfo" runat="server"></asp:Label>
            <br />
            Select company name:
            <asp:DropDownList ID="lstCompany" OnSelectedIndexChanged="lstCompany_SelectedIndexChanged" AutoPostBack="true" runat="server">
            </asp:DropDownList>
            <br />
            <asp:Label ID="lblCompanyInfo" runat="server"></asp:Label>
        </div>
    </form>
    
</body>
</html>
