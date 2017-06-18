<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Give.aspx.cs" Inherits="Give" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Donate</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="donateform" runat="server">
    <div>
        <h1>Donate</h1>
        <p>Enter the amount you would like to donate</p>
        <p><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Amount Required" ControlToValidate="DonateTextBox"></asp:RequiredFieldValidator></p>

        <p><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Only enter a dollar amount without commas or a dollar sign" ControlToValidate="DonateTextBox" ValidationExpression="^[0-9]+(\.[0-9]{1,2})?$" ></asp:RegularExpressionValidator></p>

        <p>$<asp:TextBox ID="DonateTextBox" runat="server"></asp:TextBox></p>
        <asp:Button ID="DonateButton" runat="server" Text="Donate" OnClick="DonateButton_Click" />
        <p>
            <asp:Label ID="DonateLabel" runat="server" Text=""></asp:Label>
        </p>
    </div>
    </form>
</body>
</html>
