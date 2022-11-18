<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="DataControls.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataKeyNames="ecode" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="None">
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="ecode" HeaderText="ecode" ReadOnly="True" SortExpression="ecode" />
                    <asp:BoundField DataField="ename" HeaderText="ename" SortExpression="ename" />
                    <asp:BoundField DataField="salary" HeaderText="salary" SortExpression="salary" />
                    <asp:BoundField DataField="deptid" HeaderText="deptid" SortExpression="deptid" />
                    <asp:BoundField DataField="gender" HeaderText="gender" SortExpression="gender" />
                </Columns>
                <FooterStyle BackColor="Tan" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                <SortedAscendingCellStyle BackColor="#FAFAE7" />
                <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                <SortedDescendingCellStyle BackColor="#E1DB9C" />
                <SortedDescendingHeaderStyle BackColor="#C2A47B" />
            </asp:GridView>
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CGDBConnectionString %>" DeleteCommand="DELETE FROM [employee] WHERE [ecode] = @ecode" InsertCommand="INSERT INTO [employee] ([ecode], [ename], [salary], [deptid], [gender]) VALUES (@ecode, @ename, @salary, @deptid, @gender)" SelectCommand="SELECT * FROM [employee]" UpdateCommand="UPDATE [employee] SET [ename] = @ename, [salary] = @salary, [deptid] = @deptid, [gender] = @gender WHERE [ecode] = @ecode">
                <DeleteParameters>
                    <asp:Parameter Name="ecode" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="ecode" Type="Int32" />
                    <asp:Parameter Name="ename" Type="String" />
                    <asp:Parameter Name="salary" Type="Int32" />
                    <asp:Parameter Name="deptid" Type="Int32" />
                    <asp:Parameter Name="gender" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="ename" Type="String" />
                    <asp:Parameter Name="salary" Type="Int32" />
                    <asp:Parameter Name="deptid" Type="Int32" />
                    <asp:Parameter Name="gender" Type="String" />
                    <asp:Parameter Name="ecode" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
