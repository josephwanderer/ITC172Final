<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DonationHistory.aspx.cs" Inherits="DonationHistory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="donationhistoryform" runat="server">
    <div>
        <h1>Donation History</h1>

        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        <asp:LinkButton ID="HomeButton" runat="server" PostBackUrl="~/Default.aspx">Return</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
