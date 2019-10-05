<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="lbl_state" runat="server" Text="Select A State" />
    <asp:DropDownList ID="DDLState" runat="server" OnSelectedIndexChanged="DDLState_SelectedIndexChanged" AutoPostBack="true"/>
    <asp:Label ID="lbl_city" runat="server" Text="Select A City" />
    <asp:DropDownList ID="DDLCity" runat="server" OnSelectedIndexChanged="DDLCity_SelectedIndexChanged" AutoPostBack="true"/>
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:masterConnectionString %>' SelectCommand="SELECT cityname FROM [city]"></asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
