<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lbl_name" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
         <asp:Label ID="lbl_compny_name" runat="server" Text="Company Name"></asp:Label>
         <asp:TextBox ID="txt_company_name" runat="server"></asp:TextBox>
         <asp:Label ID="lbl_salary" runat="server" Text="Salary"></asp:Label>
        <asp:TextBox ID="txt_salary" runat="server"></asp:TextBox>
        <asp:Button ID="btn_update" runat="server" Text="Update Work Details" OnClick="btn_update_Click" />
        <asp:Button ID="btn_get_details" runat="server" Text="Get Details" OnClick="btn_get_details_Click" />
        <asp:Label ID="lbl_view_area" runat="server" ></asp:Label>
    <div>
    
    </div>
    </form>
</body>
</html>
