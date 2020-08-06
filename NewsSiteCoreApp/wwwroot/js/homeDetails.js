$(function () {

    var headerContainer = $(".header-container");
    var sticky = $(headerContainer).offset().top;
    var leftInfo = $(".left-info");
    var sticky2 = $(leftInfo).offset().top;
    $(window).scroll(function () {

        if ($(window).scrollTop() > sticky) {
            $(headerContainer).addClass("sticky")

        } else if ($(window).scrollTop() == sticky) {
            $(headerContainer).removeClass("sticky");

        }
        if ($(window).scrollTop() + 90 >= sticky2) {
            $(leftInfo).addClass("sticky2")
        } else {
            $(leftInfo).removeClass("sticky2");
        }
    })
})