<%@ Page Language="VB" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Users List</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Users List</h2>
            <asp:GridView ID="UsersGridView" runat="server" AutoGenerateColumns="true">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
