$("#Rel-1").click(function () {
    $("#ProductInformation").show();
    $("#ProductRelated").hide();
    $("#ProductItems").show();
});

$("#Rel-2").click(function () {
    $("#ProductInformation").hide();
    $("#ProductRelated").show();
    $("#ProductItems").hide();

});

$(".page-content .side-navbar .list-unstyled li a").click(function () {
    var url = window.location.href;     // Returns full URL
    
    $(this).parent().addClass("active");
    
});
