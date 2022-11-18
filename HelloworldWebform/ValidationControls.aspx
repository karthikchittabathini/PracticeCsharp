<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ValidationControls.aspx.cs" Inherits="HelloworldWebform.ValidationControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            color: #FF0000;
        }
        .auto-style5 {
            color: #000000;
        }
        .auto-style6 {
            width: 174px;
            background-color: #FFFF99;
            height: 34px;
        }
        .auto-style7 {
            background-color: #FFFF99;
            height: 34px;
            width: 84%;
        }
        .auto-style12 {
            width: 174px;
            background-color: #FFFF99;
        }
        .auto-style13 {
            background-color: #FFFF99;
            width: 84%;
        }
        .auto-style14 {
            width: 174px;
        }
        .auto-style15 {
            width: 84%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td colspan="2">
                        <asp:Label ID="Label1" runat="server" CssClass="auto-style5" style="text-align: center" Text="Registration Form"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">
                        <asp:Label ID="Label2" runat="server" CssClass="auto-style2" Text="Enter UserName :"></asp:Label>
                    </td>
                    <td class="auto-style13">
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style2"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="UserName required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">
                        <asp:Label ID="Label3" runat="server" CssClass="auto-style2" Text="Enter Password :"></asp:Label>
                    </td>
                    <td class="auto-style13">
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style2"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Password required"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox3" ControlToValidate="TextBox2" ErrorMessage="Both are not same"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">
                        <asp:Label ID="Label4" runat="server" CssClass="auto-style2" Text="Re-type Password :"></asp:Label>
                    </td>
                    <td class="auto-style13">
                        <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style2"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="retype password required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label5" runat="server" CssClass="auto-style2" Text="Enter age :"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:TextBox ID="TextBox4" runat="server" CssClass="auto-style2"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Age is required" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox4" Display="Dynamic" ErrorMessage="Age must be between 18 and 100" MaximumValue="100" MinimumValue="18" SetFocusOnError="True" Type="Integer"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">
                        <asp:Label ID="Label6" runat="server" CssClass="auto-style2" Text="Enter Email id :"></asp:Label>
                    </td>
                    <td class="auto-style13">
                        <asp:TextBox ID="TextBox5" runat="server" CssClass="auto-style2"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="Email is required" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox5" Display="Dynamic" ErrorMessage="Invalid Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style14">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                    </td>
                    <td class="auto-style15">
                        <asp:Label ID="lblMsg" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" Font-Bold="True" ForeColor="Red" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
