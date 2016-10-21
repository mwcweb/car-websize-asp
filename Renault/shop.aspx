<%@ Page Title="" Language="C#" MasterPageFile="Layout.Master" AutoEventWireup="true" CodeBehind="shop.aspx.cs" Inherits="Renault.book" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="over">Shop</div>
    <div class="left">
        <table>
            <tr><td>Vare</td><td><asp:DropDownList ID="DropDownList_vare" runat="server"></asp:DropDownList></td></tr>
            <tr><td>Vare</td><td><asp:DropDownList ID="DropDownList_vare1" runat="server"></asp:DropDownList></td></tr>
            <tr><td><asp:Label ID="Label_ok" runat="server"></asp:Label>
                </td><td><asp:Button ID="Button_shop" runat="server" Text="Button" OnClick="Button_shop_Click" /></td></tr>
        </table>
        
                        <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>

    </div>
</asp:Content>
