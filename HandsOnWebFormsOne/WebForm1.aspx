<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HandsOnWebFormsOne.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Namelbl" runat="server" Text="Name"></asp:Label>
&nbsp;:
        <asp:TextBox ID="Nametxtbx" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="NameRequiredFieldValidator" runat="server" ControlToValidate="Nametxtbx" ErrorMessage="* Required Field"></asp:RequiredFieldValidator>
        <br />
        <br />
        <br />
        <asp:Label ID="phnolbl" runat="server" Text="Phone Number"></asp:Label>
&nbsp;:&nbsp;
        <asp:TextBox ID="Phnotxtbx" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="phnoRequiredFieldValidator" runat="server" ControlToValidate="Phnotxtbx" Display="Dynamic" ErrorMessage="Incorrect Phone Number. Use the following format, 999-999-9999"></asp:RequiredFieldValidator>
&nbsp;&nbsp;
        <asp:RegularExpressionValidator ID="phnoRegularExpressionValidator" runat="server" ControlToValidate="Phnotxtbx" Display="Dynamic" ErrorMessage="Incorrect Phone Number. Use the following format, 999-999-9999" SetFocusOnError="True" ValidationExpression="^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$"></asp:RegularExpressionValidator>
        <br />
        <br />
        <br />
        <asp:Label ID="emaillbl" runat="server" Text="E - Mail"></asp:Label>
&nbsp; :&nbsp;&nbsp;
        <asp:TextBox ID="emailtxtbx" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="emailRequiredFieldValidator" runat="server" ControlToValidate="emailtxtbx" Display="Dynamic" ErrorMessage="* Required Field"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RegularExpressionValidator ID="emailRegularExpressionValidator" runat="server" ControlToValidate="emailtxtbx" Display="Dynamic" ErrorMessage="Incorrect Email Address format!" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <br />
        <br />
        <br />
        <asp:Label ID="minpricelbl" runat="server" Text="Minimum Price"></asp:Label>
&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Minpricetxtbx" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="minpriceRequiredFieldValidator" runat="server" ControlToValidate="Minpricetxtbx" ErrorMessage="Has to be an integer and greater than 0"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;
        <asp:RegularExpressionValidator ID="MinPriceRegularExpressionValidator" runat="server" ControlToValidate="Minpricetxtbx" Display="Dynamic" ErrorMessage="Has to be an integer and greater than 0" SetFocusOnError="True" ValidationExpression="^[1-9][0-9]*$"></asp:RegularExpressionValidator>
        <br />
        <br />
        <br />
        <asp:Label ID="maxpricelbl" runat="server" Text="Maximum Price"></asp:Label>
&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Maxpricetxtbx" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="MaxPriceRequiredFieldValidator" runat="server" ControlToValidate="Maxpricetxtbx" Display="Dynamic" ErrorMessage="Has to be an Integer and greater than 0"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RegularExpressionValidator ID="MaxPriceRegularExpressionValidator" runat="server" ControlToValidate="Maxpricetxtbx" Display="Dynamic" ErrorMessage="Has to be an Integer and greater than 0" SetFocusOnError="True" ValidationExpression="^[1-9][0-9]*$"></asp:RegularExpressionValidator>
&nbsp;&nbsp;
        <asp:CompareValidator ID="MaxMinCompareValidator" runat="server" ControlToCompare="Minpricetxtbx" ControlToValidate="Maxpricetxtbx" Display="Dynamic" ErrorMessage="Max Price should be greater than the minimum price" Operator="GreaterThan" SetFocusOnError="True" Type="Integer"></asp:CompareValidator>
        <br />
        <br />
        <br />
        <asp:Button ID="submitbtn" runat="server" OnClick="submitbtn_Click" Text="Submit" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="submitmsglbl" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        <br />
    </form>
</body>
</html>
