<%@ Page Title="Kontakt" Language="C#" MasterPageFile="Layout.Master" AutoEventWireup="true" CodeBehind="kontakt.aspx.cs" Inherits="Renault.kontakt" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="left">
        <asp:Repeater ID="Repeater_adr" runat="server">
            <ItemTemplate>
                <%# Eval("navn") %><br />
                  <%# Eval("adr") %><br />
                  <%# Eval("postnr") %>  <%# Eval("city") %><br /><br />
                tlf:  <%# Eval("tlf") %><br />
                e--mail: <a href="mailto:<%# Eval("epost") %>" style="color:#000000"><%# Eval("epost") %></a><p></p>
            </ItemTemplate>
        </asp:Repeater>
        <div class="ned">
            <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2244.9946121594103!2d12.409595916029868!3d55.75859579901242!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x46524fe3a4d67bdf%3A0x9535af2603ba2c95!2zU2tvdiBBbGxlIDUsIDM1MDAgVsOmcmzDuHNl!5e0!3m2!1sda!2sdk!4v1453549404037" width="200" height="100" frameborder="0" style="border:0" allowfullscreen></iframe>
        </div>
    </div>
    <div class="left">
        <table>
            <tr><td>Navn</td><td><asp:TextBox ID="TextBox_navn" runat="server" ValidationGroup="form"></asp:TextBox>
                </td></tr>
            <tr><td>E-mail</td><td><asp:TextBox ID="TextBox_epost" runat="server" ValidationGroup="form"></asp:TextBox>
                               </td></tr>
            <tr><td>Emme</td><td><asp:TextBox ID="TextBox_emme" runat="server" ValidationGroup="form"></asp:TextBox>
                </td></tr>
            <tr><td>Besked</td><td><asp:TextBox ID="TextBox_besked" runat="server" ValidationGroup="form" Height="98px" style="margin-right: 0px" TextMode="MultiLine" Width="156px"></asp:TextBox>
                </td></tr>
            <tr><td><asp:Label ID="Label_send" runat="server"></asp:Label></td><td><asp:Button ID="Button_send" runat="server" Text="Send" ValidationGroup="form" OnClick="Button_send_Click" /></td></tr>
        </table>
        <p></p>
    </div>
</asp:Content>
