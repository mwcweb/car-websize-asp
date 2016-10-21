<%@ Page Title="Booking" Language="C#" MasterPageFile="Layout.Master" AutoEventWireup="true" CodeBehind="booking.aspx.cs" Inherits="Renault.booking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="over">
        <br />
        Booking</div>
    <div class="left">
        <table>
            <tr><td>Model</td><td><asp:DropDownList ID="DropDownList_model" runat="server"></asp:DropDownList></td></tr>
            <tr><td>Fra  dato</td><td><asp:TextBox ID="TextBox_fra" runat="server"></asp:TextBox> <asp:Button ID="Button_fra" runat="server" Text="Fra" OnClick="Button_fra_Click" /></td></tr>
            <tr><td>Til dato</td><td><asp:TextBox ID="TextBox_til" runat="server"></asp:TextBox> <asp:Button ID="Button_til" runat="server" Text="Til" OnClick="Button_til_Click" /></td></tr>
            <tr><td><asp:Label ID="Label_book" runat="server"></asp:Label></td><td><asp:Button ID="Button_book" runat="server" Text="Booking" OnClick="Button_book_Click" /></td></tr>
        </table>

        <p></p>
        <asp:Panel ID="Panel_fra" runat="server">
            <asp:Calendar ID="Calendar_fra" runat="server" OnSelectionChanged="Calendar_fra_SelectionChanged"></asp:Calendar>
        </asp:Panel>
    </div>
    <div class="left">
        <img src="Billeder/Side/bo.jpg" />
        <p></p>
        <asp:Panel ID="Panel_til" runat="server">
            <asp:Calendar ID="Calendar_til" runat="server" OnSelectionChanged="Calendar_til_SelectionChanged"></asp:Calendar>
        </asp:Panel>
    </div>
</asp:Content>
