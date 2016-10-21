	<script type="text/javascript" src="slider/js/sliderman.1.3.8.js"></script>

	<style type="text/css">

		* { margin: 0; outline: none; }


		#wrapper { margin: 0 auto; padding: 0 40px 60px 40px; width: 960px; }

		h2 { padding: 20px 0 10px 0; font-size: 24px; line-height: 40px; font-weight: normal; color: #adc276; text-shadow: 0 1px 3px #222222; }

	</style>

	<link rel="stylesheet" type="text/css" href="slider/css/sliderman.css" />
         <div id="SliderName">
                <img src="slider/1.jpg" alt="" />
                <img src="slider/2.jpg" alt="" />
                <img src="slider/3.jpg" alt="" />
                <img src="slider/4.jpg" alt="" />




				</div>
				<div class="c"></div>
				<div id="SliderNameNavigation"></div>
				<div class="c"></div>


				<script type="text/javascript">



					// we created new effect and called it 'demo01'. We use this name later.

					Sliderman.effect({name: 'demo01', cols: 10, rows: 5, delay: 10, fade: true, order: 'straight_stairs'});



					var demoSlider = Sliderman.slider({container: 'SliderName', width: 800, height: 533, effects: 'demo01',

					display: {

						pause: true, // slider pauses on mouseover

						autoplay: 6000, // 3 seconds slideshow

						always_show_loading: 200, // testing loading mode

						description: {background: '#ffffff', opacity: 0.5, height: 50, position: 'bottom'}, // image description box settings


						buttons: {opacity: 1, prev: {className: 'SliderNamePrev', label: ''}, next: {className: 'SliderNameNext', label: ''}}, // Next/Prev buttons settings

						navigation: {container: 'SliderNameNavigation', label: '&nbsp;'} // navigation (pages) settings

					}});



				</script>
