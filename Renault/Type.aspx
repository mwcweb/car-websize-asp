<%@ Page Title="" Language="C#" MasterPageFile="Layout.Master" AutoEventWireup="true" CodeBehind="type.aspx.cs" Inherits="Renault.Type" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div id="over"><asp:Label ID="Label_type" runat="server"></asp:Label></div>
    <asp:Repeater ID="Repeater_bil" runat="server">
        <ItemTemplate>
            <div class="model">
                <div class="mo">
                    <img src="Billeder/Model/<%# Eval("sti") %>" style="width:100px;" />
                </div>
                <div class="ren"><a href="bil.aspx?id=<%# Eval("id") %>"><%# Eval("model") %></a></div>
            </div>
        </ItemTemplate>
    </asp:Repeater>

</asp:Content>
