<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentElection.aspx.cs" Inherits="Lab5Q1.StudentElection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function MyCustomValidation(objSource, objArgs) {
            var num = objArgs.Value;
            if (num.length != 10) {
                objArgs.IsValid = false;
            }
            else {
                objArgs.IsValid = true;
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        
       
        <div>
            <asp:Panel ID="pnl" runat="server">
            Choose a candidate:&nbsp;
            <asp:DropDownList ID="lstCandidate" runat="server">
            </asp:DropDownList>
&nbsp;
            <asp:RequiredFieldValidator ID="CandidateValidator" ControlToValidate="lstCandidate" ErrorMessage="Candidate not selected." runat="server"></asp:RequiredFieldValidator>
            <br />
            House:
            <asp:RadioButtonList ID="lstHouse" runat="server">
            </asp:RadioButtonList>
                <asp:RequiredFieldValidator ID="HousrFieldValidator" ControlToValidate="lstHouse" runat="server" ErrorMessage="House not selected."></asp:RequiredFieldValidator>
            <br />
            Class:&nbsp;&nbsp;
            <asp:TextBox ID="txtClass" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RangeValidator ID="ClassValidator" ControlToValidate="txtClass" ErrorMessage="Class should be from 6-12." MinimumValue="6" MaximumValue="12" Type="Integer" runat="server" ></asp:RangeValidator>
                <asp:RequiredFieldValidator ID="ClassValidator1" ControlToValidate="txtClass" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
            <br />
            Email:&nbsp;&nbsp; <asp:TextBox ID="txtMail" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RegularExpressionValidator ID="MailValidator" ControlToValidate="txtMail" ErrorMessage="Not a valid email-id." ValidationExpression=".+@.+" runat="server"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="EmailFieldValidator" ControlToValidate="txtMail" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
            <br />
            Parents&#39;s contact no.:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CustomValidator ClientValidationFunction="MyCustomeValidation" ID="CustomValidator1" ErrorMessage="Invalid phone number." ControlToValidate="txtPhone" ValidateEmptyText="false" OnServerValidate="NumberValidator_ServerValidate" runat="server" ></asp:CustomValidator>
            <br />
            <br />
            <asp:Button ID="btnSubmit" OnClick="btnSubmit_Click" runat="server" Text="Submit" />
            <br />
            <asp:ValidationSummary ID="ValidationSummary" runat="server" />
                </asp:Panel>
            <asp:Label ID="lblMsg" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
