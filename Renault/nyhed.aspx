<%@ Page Title="" Language="C#" MasterPageFile="Layout.Master" AutoEventWireup="true" CodeBehind="nyhed.aspx.cs" Inherits="Renault.nyhed" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="over">Nyheder</div>
  <asp:Repeater ID="Repeater_nyhed" runat="server">
        <ItemTemplate>
            <div class="nyh"><a href="ny.aspx=id=<%# Eval("Id") %>"><%# Eval("overskr") %></a></div>
            <div class="dato"><%# Eval("dato") %></div>
            <div class="clear"></div>
        </ItemTemplate>
    </asp:Repeater>
          <div style="height:20px"></div>
        <asp:Repeater ID="rptPaging" runat="server" onitemcommand="rptPaging_ItemCommand">
            <ItemTemplate>
                                <asp:LinkButton ID="btnPage"
                 style="padding:8px; margin:2px; background:#ccc; border:solid 1px #666; font:8pt tahoma #000;"
                CommandName="Page" CommandArgument="<%# Container.DataItem %>"
                 runat="server" ForeColor="White" Font-Bold="True"><%# Container.DataItem %>
                                </asp:LinkButton>
           </ItemTemplate>
        </asp:Repeater>
    <asp:GridView ID="GridView_nyh" runat="server" BorderColor="#fff"></asp:GridView>
 </asp:Content>