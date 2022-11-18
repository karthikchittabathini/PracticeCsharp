<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="HelloworldWebform.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
        </div>
        <asp:Label ID="Label1" runat="server" Text="Enter your name"></asp:Label>
&nbsp;:&nbsp;&nbsp;
        <asp:TextBox ID="txtName" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDisplay" runat="server" OnClick="btnDisplay_Click" Text="Display" Width="114px" />
        <p>
            <asp:Label ID="lblMsg" runat="server" ForeColor="Green"></asp:Label>
        </p>
    </form>
    <table border="1" style="width:100%;">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</body>
</html>
