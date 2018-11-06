var standalone = window.navigator.standalone,
    userAgent = window.navigator.userAgent.toLowerCase(),
    safari = /safari/.test( userAgent ),
    ios = /iphone|ipod|ipad/.test( userAgent );
	var iHeight = window.screen.height;
if( ios ) {
	


  

    if( iHeight >= 736 && 812 > iHeight)

   {

		$(".slider1").attr("src", "/MyLayout/Midas-Main/img/iosslider1.jpg");
        $(".slider2").attr("src", "/MyLayout/Midas-Main/img/iosslider2.jpg");
        $(".offer-silder-cont3").attr("src", "/MyLayout/Midas-Main/img/ios1.jpg");

   }

   else if(iHeight > 811)

   {

        $(".slider1").attr("src", "/MyLayout/Midas-Main/img/iosslider3.jpg");
        $(".slider2").attr("src", "/MyLayout/Midas-Main/img/iosslider4.jpg");
        $(".offer-silder-cont3").attr("src", "/MyLayout/Midas-Main/img/ios3.jpg");

   }
    
  
} else {
    
  
    
};