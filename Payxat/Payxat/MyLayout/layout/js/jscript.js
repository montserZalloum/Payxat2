


/*---------------------
 mobile side nav
---------------------*/

	$(".open").click(function(){

        $(".sideMenu").addClass("Active");

});

$(".closs").click(function () {
    $(".sideMenu").removeClass("Active");
	
});
/*---------------------
 side nav dropdown list
---------------------*/

$(".sideList1").click(function () {
    $(".sideListHidden1").slideToggle();
    
   
});

$(".sideList2").click(function () {
    $(".sideListHidden2").slideToggle();


});

/*---------------------
 close side nav when click outside
---------------------*/
