$(function () {
    
    $(document).on("click",".nav-toggle",function () {
        $("body").toggleClass("body_nav_visible");
        $("nav").css({
            "height":$(document).height()+"px"
        }) 

    })
    $(document).on("click",".search-toggle",function () {
        $(this).hide();
        $(".header-container").toggleClass("header-primary_search");
    })

    $(document).on("click", ".stats_likes", function () {
        $(this).click(false);
      
        var id_ = $(this).parent().attr("data-id");
        $(`.stats[data-id=${id_}] .stats_dislikes`).click(false);
        var data_ = {
            id:id_
        }
        $.ajax({
            url: "/Home/AddLike",
            type: "post",
            data: data_,
            dataType: "json",
            success: function () {  
                var count = $(`.stats[data-id=${id_}] .stats_likes`).find(".stats-item").text();
                count++;
                $(`.stats[data-id=${id_}] .stats_likes`).find(".stats-item").text(count);
            },
            error: function () {
                console.log("error")
            }
        })

    })
    $(document).on("click", ".stats_dislikes", function () {
        $(this).click(false);
        
        var id_ = $(this).parent().attr("data-id");
        $(`.stats[data-id=${id_}] .stats_likes`).click(false);
        var data_ = {
            id: id_
        }
        $.ajax({
            url: "/Home/AddDislike",
            type: "post",
            data: data_,
            dataType: "json",
            success: function () {
                var count = $(`.stats[data-id=${id_}] .stats_dislikes`).find(".stats-item").text();
                console.log(count)
                count++;
                $(`.stats[data-id=${id_}] .stats_dislikes`).find(".stats-item").text(count);
            },
            error: function () {
                console.log("error")
            }
        })

    })
})