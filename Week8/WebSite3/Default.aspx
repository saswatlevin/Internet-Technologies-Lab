<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lbl_flavour" runat="server" Text="Flavour"></asp:Label>
        <asp:TextBox ID="txt_flavour" runat="server"></asp:TextBox>
        <asp:Label ID="lbl_price" runat="server" Text="Price"></asp:Label>
        <asp:TextBox ID="txt_price" runat="server"></asp:TextBox>
        <asp:Button ID="btn_update" runat="server" Text="Update" OnClick="btn_update_Click" />

    </div>
    </form>
</body>
</html>
