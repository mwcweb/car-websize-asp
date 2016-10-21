<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Renault.cms.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button_log" runat="server" Text="log ud" OnClick="Button_log_Click" />
        <table>
            <tr><td>Kat</td><td><asp:DropDownList ID="DropDownList_kat" runat="server"></asp:DropDownList></td></tr>
            <tr><td><asp:Label ID="Label_slet" runat="server"></asp:Label></td><td><asp:Button ID="Button_slet" runat="server" Text="Slet" OnClick="Button_slet_Click" /></td></tr>
        </table>
    
    </div>
    </form>
</body>
</html>
