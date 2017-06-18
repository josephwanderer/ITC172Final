<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Events.aspx.cs" Inherits="Events" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Events</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="eventform" runat="server">
    <div>
    <asp:Calendar ID="EventCalendar" runat="server" OnSelectionChanged="EventCalendar_SelectionChanged"></asp:Calendar>
    <asp:Label ID="ResultLabel" runat="server" Text="" CssClass="result"></asp:Label>
    </div>
    </form>
</body>
</html>
