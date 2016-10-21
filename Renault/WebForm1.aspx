
<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Renault.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div id="over">
         <br />
         Log ind</div>
    <div class="left">
        <table>
            <tr><td>Brn</td><td><asp:TextBox ID="TextBox_brn" runat="server"></asp:TextBox></td></tr>
            <tr><td>Pass</td><td><asp:TextBox ID="TextBox_pass" runat="server" TextMode="Password"></asp:TextBox></td></tr>
            <tr><td><asp:Label ID="Label_ok" runat="server"></asp:Label></td><td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                                                                             </td></tr>
        </table>
    </div>
</asp:Content>
