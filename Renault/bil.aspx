
<%@ Page Title="" Language="C#" MasterPageFile="Layout.Master" AutoEventWireup="true" CodeBehind="bil.aspx.cs" Inherits="Renault.bil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="Repeater_model" runat="server">
        <ItemTemplate>
            <div id="over"><%# Eval("model") %></div>
            <div class="left">
                <img src="Billeder/model/<%# Eval("sti") %>" />
                <div class="ned">Motor: <%# Eval("motor") %></div>
                <div class="ned">Brændstof: <%# Eval("stof") %></div>
                <div class="ned">Pris: <%# string.Format("{0:##,###.###}", Eval("pris")) %> kr</div>
            </div>
            <div class="left">
                Dagpris: <%# string.Format("{0:##,###.##}",Eval("dagpris")) %> kr 
                <div id="til"><a href="model.aspx">Tilbage</a></div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
