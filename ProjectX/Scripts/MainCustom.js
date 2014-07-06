$(document).ready(function () {
    
    $("#btnDescribePlace").click(function () {
        var classe = "";
        $.post("/DescribePlace/RetornarViewAjax")
                .done(function (data) {
                    $("#overlay").show();
                    $("#ModalContent").html(data);
                    $("#modal").addClass(classe);
                    $("body").css("overflow", "hidden");
                    responsive();
                });
        return false;
    });

    $("#btnPosts").click(function () {
        var classe = "modalPosts";
        $.post("/Posts/RetornarViewAjax")
                .done(function (data) {
                    $("#overlay").show();
                    $("#ModalContent").html(data);
                    $("#modal").addClass(classe);
                    $("body").css("overflow", "hidden");
                    responsive();
                });
        return false;
    });

    responsive();

    $(window).resize(function () {
        responsive();
    });


});


function closeModal() {
    $("#overlay").hide();
    $("#ModalContent").html("");
    $("body").css("overflow", "auto");
    return false;
}


function responsive() {
    var wdt = $(document).width();
    if (wdt < 500) {
        $("#txtDesc").attr("id", "txtDescResponsivo");
        $("#ddPlace").attr("id", "ddPlaceResponsivo");
        $("#divTrackQuantity").attr("id", "divTrackQuantityResponsive");
        $("#divTrackQuality").attr("id", "divTrackQualityResponsive");

        $(".modalPosts").addClass("modalPostsResponsive");
    } else {
        $("#txtDescResponsivo").attr("id", "txtDesc");
        $("#ddPlaceResponsivo").attr("id", "ddPlace");
        $("#divTrackQuantityResponsive").attr("id", "divTrackQuantity");
        $("#divTrackQualityResponsive").attr("id", "divTrackQuality");

        $(".modalPostsResponsive").removeClass("modalPostsResponsive");
    }
}