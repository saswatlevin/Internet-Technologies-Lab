<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lbl_category" Text="Category" runat="server" />
        <asp:DropDownList ID="DDLCategory" runat="server" OnSelectedIndexChanged="DDLCategory_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
         <asp:Label ID="lbl_names" Text="Name" runat="server" />
         <asp:ListBox ID="LBNames" runat="server" OnSelectedIndexChanged="LBNames_SelectedIndexChanged" AutoPostBack="true"></asp:ListBox>
        <br />
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:masterConnectionString %>' SelectCommand="SELECT * FROM [actor] WHERE ([name] = @name)">
            <SelectParameters>
                <asp:ControlParameter ControlID="LBNames" PropertyName="SelectedValue" Name="name" Type="String"></asp:ControlParameter>
            </SelectParameters>
        </asp:SqlDataSource>
         <asp:Label ID="lbl_details" Text="Details" runat="server" />

        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1"></asp:GridView>
    </div>
    </form>
</body>
</html>
