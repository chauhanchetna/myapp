<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DDL_DataBase.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>    
                    Select State:: <asp:DropDownList ID="ddlstate" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlstate_SelectedIndexChanged">
                    </asp:DropDownList>
                    <br />
                    Select City:: <asp:DropDownList ID="ddlcity" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
