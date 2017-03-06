<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Question1.aspx.cs" Inherits="Question1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registation form</title>
   
</head>
<body>
    <form id="form1" runat="server">
        <center>
        <h2>Registration Form</h2>
        <table>
            <tr>
                <td>Username :-</td>
                <td>
                    <asp:TextBox ID="t1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="l2" runat="server" ForeColor="Red" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Password :-</td>
                <td>
                    <asp:TextBox ID="t2" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="l3" runat="server" ForeColor="Red" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Confirmed Password :-</td>
                <td>
                    <asp:TextBox ID="t3" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="l4" runat="server" ForeColor="Red" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td>First Name :-</td>
                <td>
                    <asp:TextBox ID="t4" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="l5" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Last Name :-</td>
                <td>
                    <asp:TextBox ID="t5" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="l6" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Email :-</td>
                <td>
                    <asp:TextBox ID="t6" runat="server" TextMode="Email"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="l7" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Phone No. :-</td>
                <td>
                    <asp:TextBox ID="t7" runat="server" TextMode="Phone"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="l8" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Location :-</td>
                <td>
                    <asp:TextBox ID="t8" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="l9" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Button ID="b1" runat="server" Text="Save" OnClick="b1_Click"/>
                    <asp:Button ID="b2" runat="server" Text="Reset" OnClick="b2_Click" />
                </td>
            </tr>
        </table>
            <asp:Label ID="l1" runat="server" Text="" ForeColor="Green"></asp:Label>
            <br /><br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowCommand="GridView1_RowCommand" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
            <Columns>
                <asp:TemplateField HeaderText="First Name">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("firstname") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("firstname") %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Last Name">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Eval("lastname") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("lastname") %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Email">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Eval("email") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("email") %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Phone No.">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Eval("phone_no") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("phone_no") %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Location">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox5" runat="server" Text='<%# Eval("location") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("location") %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Action">
                    <EditItemTemplate>
                        <asp:Button ID="Button3" runat="server" Text="Update" CommandName="Update" CommandArgument='<%# Eval("id") %>'/>
                        <asp:Button ID="Button4" runat="server" Text="Cancel" CommandName="Cancel" CommandArgument='<%# Eval("id") %>'/>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Button ID="Button1" runat="server" Text="Edit" CommandName="Edit" CommandArgument='<%# Eval("id") %>'/>
                        <asp:Button ID="Button2" runat="server" Text="Delete" CommandName="Delete" CommandArgument='<%# Eval("id") %>' />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />

        </asp:GridView>
    </center>
    </form>
</body>
</html>
