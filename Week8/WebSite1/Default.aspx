<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lbl_ddl" runat="server" Text="StaffID"></asp:Label>
        <asp:DropDownList ID="DDLStaffId" runat="server" OnSelectedIndexChanged="DDLStaffId_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
        <asp:Label ID="lbl_ListBox" runat="server" Text="ListBox"></asp:Label>
        <asp:ListBox ID="LBNotify" runat="server"></asp:ListBox>
        <asp:Label ID="lbl_Display" runat="server"></asp:Label>
        <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" />
    </div>
        
    </form>
</body>
</html>
