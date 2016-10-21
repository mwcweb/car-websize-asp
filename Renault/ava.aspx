<%@ Page Title="Avanceret søg" Language="C#" MasterPageFile="Layout.Master" AutoEventWireup="true" CodeBehind="ava.aspx.cs" Inherits="Renault.ava" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="over">Avanceret søg</div>
    <div class="left">
        <table>
            <tr><td>Model</td><td><asp:TextBox ID="TextBox_model" runat="server"></asp:TextBox></td></tr>
            <tr><td>Pris</td><td><asp:TextBox ID="TextBox_fra" runat="server"></asp:TextBox> <asp:TextBox ID="TextBox_til" runat="server"></asp:TextBox></td></tr>
            <tr><td>Brændstof</td><td><asp:CheckBox ID="CheckBox_el" runat="server" /> El <asp:CheckBox ID="CheckBox_diesel" runat="server" /> Diesel <asp:CheckBox ID="CheckBox_benzin" runat="server" /> Benzin</td></tr>
            <tr><td></td><td><asp:Button ID="Button_sog" runat="server" Text="Søg" OnClick="Button_sog_Click" /></td></tr>
        </table>
    </div>
    <div class="left">
        <img src="Billeder/Side/lup.jpg" />
    </div>
    <div style="clear:left"></div>
    <asp:Repeater ID="Repeater_model" runat="server">
        <ItemTemplate>
            <div class="model">
                <div class="mo">
                    <img src="Billeder/model/<%# Eval("sti") %>" style="width:100px" alt="<%# Eval("model") %>" />
                </div>
                <div class="tek"><a href="bil.aspx?id=<%# Eval("Id") %>"><%# Eval("model") %></a></div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
