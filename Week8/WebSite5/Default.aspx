<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lbl_manufacturer" runat="server" Text="Select a manufacturer"></asp:Label>
        <asp:DropDownList ID="DDLManufacturer" runat="server" OnSelectedIndexChanged="DDLManufacturer_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
       <br />
       <br />
         <asp:Label ID="lbl_model_name" runat="server" Text="Enter a model name"></asp:Label>
        <asp:TextBox ID="txt_model_name" runat="server"></asp:TextBox>
        <br />
       <br />
      <asp:Button ID="btn_submit" runat="server" Text="Submit" OnClick="btn_submit_Click" />

    </div>
    </form>
</body>
</html>
