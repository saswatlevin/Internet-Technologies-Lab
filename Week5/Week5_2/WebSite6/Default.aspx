<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="lbl_name" Text="Name" runat="server" />
    <asp:TextBox ID="txt_name" runat="server"/>
    <br />
    <br />
    <asp:Label ID="lbl_rollNo" Text="Roll Number" runat="server" />
    <asp:TextBox ID="txt_rollno" runat="server" />
    <br />
    <br />
    <asp:Label ID="lbl_subject" Text="Select A Subject" runat="server" />
    <asp:DropDownList ID="DDLSubject" runat="server" OnSelectedIndexChanged="DDLSubject_SelectedIndexChanged" />
        <br />
        <br />
   <asp:Button ID="btn_submit" runat="server" Text="Submit" OnClick="btn_submit_Click" />
    

    </div>
    </form>
</body>
</html>
