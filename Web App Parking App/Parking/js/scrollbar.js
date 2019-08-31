////(function ($) {
////    $(document).ready(function () {

////        // hide .navbar first
////        $(".navbar").show();

////        // fade in .navbar
////        $(function () {
////            $(window).scroll(function () {
////                // set distance user needs to scroll before we fadeIn navbar
////                if ($(this).scrollTop() < 5) {
////                    $('.navbar').fadeIn();
////                } else {
////                    $('.navbar').fadeOut();
////                }
////            });
////        });

////    });
////}(jQuery));

$(document).ready(function () {
    $('#footer').hide();
    $(window).scroll(function () {
        if ($('body').height() <= ($(window).height() + $(window).scrollTop())) {
            $('#footer').fadeIn();
        } else {
            $('#footer').fadeOut();
        }
    });
});


//var mywindow = $(window);
//var mypos = mywindow.scrollTop();
//var up = false;
//var newscroll;
//mywindow.scroll(function () {
//    newscroll = mywindow.scrollTop();
//    if (newscroll > mypos && !up) {
//        $('#navscroll').fadeOut();
//        up = !up;
//        console.log(up);
//    } else if (newscroll < mypos && up) {
//        $('#navscroll').fadeIn();
//        up = !up;
//    }
//    mypos = newscroll;
//});