<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Question3.aspx.cs" Inherits="Question3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <center>
            <h2>Number of Employee for Each Department</h2>
            <br />
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField HeaderText="Department Name">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("Dname") %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Number of Employee">
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("NumberofEmployee") %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
            </Columns>
        </asp:GridView>   
        </center>
        
        
        
    </form>
</body>
</html>
