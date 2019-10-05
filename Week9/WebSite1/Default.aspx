<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lbl_fruit_display" runat="server" Text="Choose A Fruit" />
        <asp:CheckBoxList ID="CBLFruit" runat="server" OnSelectedIndexChanged="CBLFruit_SelectedIndexChanged" AutoPostBack="true"/>
         <asp:Label ID="Label1" runat="server" Text="Choose An Ice Cream" />
        <asp:RadioButtonList ID="RBLIceCream" runat="server" OnSelectedIndexChanged="RBLIceCream_SelectedIndexChanged" AutoPostBack="true"/>
        <asp:Label ID="lbl_view_area" runat="server" />
    </div>
    </form>
</body>
</html>
