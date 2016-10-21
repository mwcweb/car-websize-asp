
<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Renault.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="rum" style="width:295px">
        <div id="sli">
          	<script type="text/javascript" src="slider/jas/sliderman.1.3.8.js"></script>

	<style type="text/css">

		* { margin: 0; outline: none; }


		#wrapper { margin: 0 auto; padding: 0 40px 60px 40px; width: 960px; }

		h2 { padding: 20px 0 10px 0; font-size: 24px; line-height: 40px; font-weight: normal; color: #adc276; text-shadow: 0 1px 3px #222222; }
</style>
	<link rel="stylesheet" type="text/css" href="slider/csst/sliderman.css" />
         <div id="SliderName">
            <asp:Repeater ID="Repeater_bil" runat="server">
                <ItemTemplate>
                    <img src="Billeder/Side/<%# Eval("sti") %>" />
                </ItemTemplate>
            </asp:Repeater>
        </div>
         
				</div>
				<div class="c"></div>
				<div id="SliderNameNavigation"></div>
				<div class="c"></div>


				<script type="text/javascript">



					// we created new effect and called it 'demo01'. We use this name later.

					Sliderman.effect({name: 'demo01', cols: 10, rows: 5, delay: 10, fade: true, order: 'straight_stairs'});



					var demoSlider = Sliderman.slider({container: 'SliderName', width: 255, height: 188, effects: 'demo01',

					display: {

						pause: true, // slider pauses on mouseover

						autoplay: 6000, // 3 seconds slideshow

						always_show_loading: 200, // testing loading mode

						description: {background: '#ffffff', opacity: 0.5, height: 50,}, // image description box settings


						buttons: {opacity: 1, prev: {className: 'SliderNamePrev', label: ''}, next: {className: 'SliderNameNext', label: ''}}, // Next/Prev buttons settings

						navigation: {container: 'SliderNameNavigation', label: '&nbsp;'} // navigation (pages) settings

					}});



				</script>    
        <div class="top">
            <a href="udlej.aspx"><img src="Billeder/Side/lup.jpg"</a>
        </div>
        
    </div>
    <div class="rum">
        <div class="tek">
            Vi har alle model indefor Renault fra minibil til erhver bil
vi er Danmark bedet bil forhandler i Renault
        </div>
    </div>
    <div class="rum">
        <div class="top">
            <img src="Billeder/Side/nogle.png" />
        </div>
        <div class="top">
            <div class="tek">Udlejning en bil for en dagUdlejning en bil for en dag</div>
        </div>
    </div>
</asp:Content>
