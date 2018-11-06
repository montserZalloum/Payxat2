/*
	Megacount Template Scripts
*/

(function($){ "use strict";
    // The slider being synced must be initialized first

  $('.menu-nav').height($(window).height());
  $('.Mainsection').height($(window).height() - 80);
  $('.offer-silder-cont3').height($(window).height() - 50);
  $('.links').height($(window).height() - 80);


  
  $('.romitem').owlCarousel({
    loop:true,
    margin:5,
	 navText: ["<i class='fa fa-angle-right'></i>","<i class='fa fa-angle-left'></i>"],
    nav:true,
	dots:false,
    responsive:{
        0:{
            items:3
        },
        600:{
            items:3
        },
        1000:{
            items:4
        }
    }
}); 


 
   $(".rslides").responsiveSlides({
  auto: false,             // Boolean: Animate automatically, true or false
  speed: 500,            // Integer: Speed of the transition, in milliseconds
  timeout: 4000,          // Integer: Time between slide transitions, in milliseconds
  pager: false,           // Boolean: Show pager, true or false
  nav: true,             // Boolean: Show navigation, true or false
  random: false,          // Boolean: Randomize the order of the slides, true or false
  pause: false,           // Boolean: Pause on hover, true or false
  pauseControls: true,    // Boolean: Pause when hovering controls, true or false
  prevText: "<i class='fa fa-angle-right'></i>",   // String: Text for the "previous" button
  nextText: "<i class='fa fa-angle-left'></i>",       // String: Text for the "next" button
  maxwidth: "",           // Integer: Max-width of the slideshow, in pixels
  navContainer: "",       // Selector: Where controls should be appended to, default is after the 'ul'
  manualControls: "",     // Selector: Declare custom pager navigation
  namespace: "rslides",   // String: Change the default namespace used
  before: function(){},   // Function: Before callback
  after: function(){}     // Function: After callback
});



 $('.realted').owlCarousel({
    loop:true,
    margin:5,
	 navText: ["<i class='fa fa-angle-right'></i>","<i class='fa fa-angle-left'></i>"],
    nav:true,
	dots:false,
    responsive:{
        0:{
            items:3
        },
        600:{
            items:3
        },
        1000:{
            items:4
        }
    }
});


$( ".menu-mob" ).click(function() {
  $(".menu-nav").addClass('menu-active');
    $("body").addClass('stop-scroll');
});



$( ".off" ).click(function() {
  $(".on").addClass('showlight');
  $(this).addClass('hidden');
  $(".overlay-land").fadeOut('slow');
  $(".lighten").fadeOut('slow');
  
});



$( ".arrowhome" ).click(function() {
  $('html, body').animate({
                        scrollTop: $(".main-cat-sec").offset().top
                    }, 2000);

});

$( ".menu-close" ).click(function() {
  $(".menu-nav").removeClass('menu-active');
 $("body").removeClass('stop-scroll');
});


$('a[href*="#"]')
  // Remove links that don't actually link to anything
  .not('[href="#"]')
  .not('[href="#0"]')
  .click(function(event) {
    // On-page links
    if (
      location.pathname.replace(/^\//, '') == this.pathname.replace(/^\//, '') 
      && 
      location.hostname == this.hostname
    ) {
      // Figure out element to scroll to
      var target = $(this.hash);
      target = target.length ? target : $('[name=' + this.hash.slice(1) + ']');
      // Does a scroll target exist?
      if (target.length) {
        // Only prevent default if animation is actually gonna happen
        event.preventDefault();
        $('html, body').animate({
          scrollTop: target.offset().top-50
        }, 1000, function() {
          // Callback after animation
          // Must change focus!
        
        });
      }
    }
	$(".menu-nav").removeClass('menu-active');
	$("body").removeClass('stop-scroll');
  });

})(jQuery);







