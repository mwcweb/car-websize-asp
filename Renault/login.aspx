<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Renault.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div id="over">Log ind</div>
    <div class="left">
        <table>
            <tr><td>Brn</td><td><asp:TextBox ID="TextBox_brn" runat="server"></asp:TextBox></td></tr>
            <tr><td>Pass</td><td><asp:TextBox ID="TextBox_pass" runat="server" TextMode="Password"></asp:TextBox></td></tr>
            <tr><td><asp:Label ID="Label_ok" runat="server"></asp:Label></td><td><asp:Button ID="Button_log" runat="server" Text="Log ind" OnClick="Button_log_Click" /></td></tr>
        </table>
    </div>
</asp:Content>
