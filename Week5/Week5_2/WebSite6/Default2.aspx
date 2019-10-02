<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="lbl_name"  runat="server" />
    <asp:Label ID="lbl_subject"  runat="server" />
    <br />
    <br />
    <asp:Button ID="btn_goback" Text="Go Back" runat="server" OnClick="btn_goback_Click" />
    </div>
    </form>
</body>
</html>
