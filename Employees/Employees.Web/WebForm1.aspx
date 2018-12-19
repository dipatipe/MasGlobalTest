<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Employees.Web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 128px;
        }
        .auto-style3 {
            width: 91%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        <asp:Button ID="btnGetEmployee" runat="server" OnClick="btnGetEmployee_Click" Text="GetEmployees" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:GridView ID="gvEmployee" runat="server">
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
