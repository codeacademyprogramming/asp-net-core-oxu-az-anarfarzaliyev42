$(function () {

    var headerContainer = $(".header-container");
    var sticky = $(headerContainer).offset().top;
    $(window).scroll(function () {

        if ($(window).scrollTop() > sticky) {
            $(headerContainer).addClass("sticky")

        }
        else if ($(window).scrollTop() == sticky) {
            $(headerContainer).removeClass("sticky");
        }

    })
    //Slider written here
    var countOfSliderImage = $(".slider-content .slider-item").length;
    var margin = 0;
    var i = 0;
    setInterval(function () { addMargin() }, 5000);

    $(document).on("click", ".slider-arrow", function () {
        if ($(this).hasClass("slider-arrow_next")) {
            if ((countOfSliderImage - 1) == i) {
                margin = 0
                i = 0
            }
            else {
                margin -= 620;
                i++
            }
         
            $(".slider-content").css({
                marginLeft: '' + margin + '' + 'px'

            })
        }
        else if ($(this).hasClass("slider-arrow_prev")) {
       

            if (i == 0) {
                margin = (-620) * (countOfSliderImage - 1)
                i = countOfSliderImage - 1
            }
            else {
                margin += 620;
                i--
            }
       
            $(".slider-content").css({
                marginLeft: '' + margin + '' + 'px'

            })
        }
    })
    function addMargin() {

        if ((countOfSliderImage - 1) == i) {
            margin = 0
            i = 0
        }
        else {
            margin -= 620;
            i++
        }
       
        $(".slider-content").css({
            marginLeft: '' + margin + '' + 'px'

        })
    }
})