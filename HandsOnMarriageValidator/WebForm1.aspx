<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HandsOnMarriageValidator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style2">
        <asp:Label ID="Label1" runat="server" Text="<h1> Marriage Validator </h1>"></asp:Label>
        </div>
    <p class="auto-style2">
        <asp:Label ID="bridgeAgelbl" runat="server" Text="Bridge's Age"></asp:Label>
&nbsp; :&nbsp;&nbsp;
        <asp:TextBox ID="bridgeAgetxt" runat="server"></asp:TextBox>
&nbsp; 
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="bridgeAgetxt" ErrorMessage="Invalid Message" Operator="GreaterThanEqual" Type="Integer" ValueToCompare="18"></asp:CompareValidator>
        </p>
        <p class="auto-style2">
            <asp:Label ID="Label2" runat="server" Text="Groom's Age"></asp:Label>
&nbsp; :&nbsp;
            <asp:TextBox ID="groomAge" runat="server"></asp:TextBox>
&nbsp;&nbsp;
            <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="groomAge" ErrorMessage="Invalid Message" Operator="GreaterThanEqual" Type="Integer" ValueToCompare="21"></asp:CompareValidator>
        </p>
        <p class="auto-style2">
            <asp:Button ID="Button1" runat="server" Text="Validate" OnClick="Button1_Click" />
        &nbsp;&nbsp;
        </p>
        <p class="auto-style2">
            &nbsp;&nbsp;
            <asp:Label ID="finalmsg" runat="server"></asp:Label>
        </p>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        <p class="auto-style2">
            &nbsp;</p>
        <p class="auto-style2">
            &nbsp;</p>
        <p class="auto-style2">
            &nbsp;</p>
        <p class="auto-style2">
            &nbsp;</p>
    </form>
    </body>
</html>
