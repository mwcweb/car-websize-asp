<%@ Page Title="Søg" Language="C#" MasterPageFile="Layout.Master" AutoEventWireup="true" CodeBehind="sog.aspx.cs" Inherits="Renault.sog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="over">Søg</div>
    <asp:Repeater ID="Repeater_bil" runat="server">
        <ItemTemplate>
            <div class="model">
                <div class="mo">
                    <img src="Billeder/Model/<%# Eval("sti") %>" style="width:100px;"/>
                </div>
                <div class="ren"><a href="bil.aspx?id=<%# Eval("id") %>"><%# Eval("model") %></a></div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
