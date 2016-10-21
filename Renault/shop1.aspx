<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="shop1.aspx.cs" Inherits="Renault.shop1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 85px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div id="over">Shop</div>
    <div class="left">
        <table>
            <tr><td>Vare</td><td>
                <asp:TextBox ID="TextBox_va" runat="server"></asp:TextBox></td><td class="auto-style1">
                    
                    <asp:button runat="server" text="-" ID="mus" OnClick="mus_Click" />
                    
                    <asp:TextBox ID="TextBox_antal" runat="server" Width="18px">1</asp:TextBox>
                    <asp:Button ID="Button_plus" runat="server" Text="+" OnClick="Button_plus_Click" />
                </td>
            </tr>
            <tr><td>Vare</td><td>
                <asp:TextBox ID="TextBox_v" runat="server"></asp:TextBox></td><td class="auto-style1">
                    <asp:Button ID="Button_mums" runat="server" OnClick="Button_mums_Click" Text="-" />
                    <asp:TextBox ID="TextBox_a" runat="server" Width="18px">1</asp:TextBox>
                    <asp:Button ID="Button_" runat="server" Text="+" OnClick="Button__Click" />
            </tr>
               <tr><td>Sum</td><td>
                <asp:TextBox ID="TextBox_sum" runat="server"></asp:TextBox></td><td> 
                       <asp:Button ID="Button_op" runat="server" OnClick="Button_op_Click" Text="Opdare" />
                   </td></tr>
            <tr><td><asp:Label ID="Label_ok" runat="server"></asp:Label>
                </td><td><asp:Button ID="Button_shop" runat="server" Text="Button" OnClick="Button_shop_Click" /></td></tr>
        </table>
        </div>
</asp:Content>
