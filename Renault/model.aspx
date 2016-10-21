<%@ Page Title="Model" Language="C#" MasterPageFile="Layout.Master" AutoEventWireup="true" CodeBehind="model.aspx.cs" Inherits="Renault.model" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        /*model*/
#over{
    width:800px;
    padding-top:20px;
    font-size:20px;
    text-align:center;
}
.model{
    width:100px;
    height:120px;
    float:left;
    padding:15px;
}
.mo{
    height:80px;
}
.ren{
    padding-top:5px;
    font-size:12px;
}
.ren a:link, .ren a:visited{
    color:#000;
    text-decoration:underline;
    font-size:12px;
}
.ren a:hover{
    text-decoration:none;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div id="over">Model</div>
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
