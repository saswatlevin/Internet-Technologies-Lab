<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<!--<asp:ControlParameter ControlID="txt_enter" PropertyName="Text" Name="place_name" Type="String"></asp:ControlParameter>-->
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1">

        </asp:GridView>
        <asp:TextBox ID="txt_enter" runat="server" />
        <asp:Button ID="btn_go" runat="server" Text="Go" OnClick="btn_go_Click" />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:masterConnectionString %>' SelectCommand="SELECT * FROM [places]">
           
        </asp:SqlDataSource>
     
    </div>
    </form>
</body>
</html>
