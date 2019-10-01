<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:Label ID="lbl_genre" runat="server" Text="Genre"/>
        <asp:DropDownList ID="DDLGenre" runat="server"  AutoPostBack="true" OnSelectedIndexChanged="DDLGenre_SelectedIndexChanged"></asp:DropDownList>
        <asp:Label ID="lbl_actors" runat="server" Text="Actors"  />
        <asp:ListBox ID="LBActors" runat="server" OnSelectedIndexChanged="LBActors_SelectedIndexChanged" AutoPostBack="true"></asp:ListBox>
        <asp:Label ID="lbl_view_area" runat="server" />
    </div>
    </form>
</body>
</html>
