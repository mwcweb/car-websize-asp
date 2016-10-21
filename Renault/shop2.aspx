<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="shop2.aspx.cs" Inherits="Renault.shop2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> <div id="over">Shop</div>
    <div class="left">
        <table>
            <tr><td>Vare</td><td>
                <asp:TextBox ID="TextBox_va" runat="server"></asp:TextBox></td><td class="auto-style1">
            
                    <asp:TextBox ID="TextBox_antal" runat="server" Width="18px"></asp:TextBox>
            
                                  </td>
            </tr>
            <tr><td>Vare</td><td>
                <asp:TextBox ID="TextBox_v" runat="server"></asp:TextBox></td><td class="auto-style1">
                     <asp:TextBox ID="TextBox_a" runat="server" Width="18px"></asp:TextBox>
                    
            </tr>
               <tr><td>Sum</td><td>
                <asp:TextBox ID="TextBox_sum" runat="server"></asp:TextBox></td><td> 
                   
                   </td></tr>
            <tr><td>Navn</td><td><asp:TextBox ID="TextBox_navn" runat="server"></asp:TextBox></td></tr>
            <tr><td>E-mail</td><td><asp:TextBox ID="TextBox_epost" runat="server"></asp:TextBox></td></tr>
            <tr><td><asp:Label ID="Label_ok" runat="server"></asp:Label>
                </td><td><asp:Button ID="Button_shop" runat="server" Text="Button" OnClick="Button_shop_Click" /></td></tr>
        </table>
        </div>
</asp:Content>
