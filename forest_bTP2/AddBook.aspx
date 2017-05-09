<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="forest_bTP2.AddBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Title"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" ToolTip="slt"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Autheur"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Height="16px" Width="89px"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="Date"></asp:Label>
            <asp:Calendar ID="Calendar1" runat="server" Height="83px" Width="92px"></asp:Calendar>
            <asp:Button ID="Button1" runat="server" Text="Sauvegarder" OnClick="add" />
        </div>
    </form>
</body>
</html>
