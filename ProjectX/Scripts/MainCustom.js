$(document).ready(function () {
    
    $("#btnDescribePlace").click(function () {
        var classe = "";
        $.post("/DescribePlace/RetornarViewAjax")
                .done(function (data) {
                    $("#overlay").show();
                    $("#ModalContent").html(data);
                    $("#modal").addClass(classe);
                    $("body").css("overflow", "hidden");
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
                });
        return false;
    });

    $(window).resize(function () {
        var wdt = $(document).width();
        if (wdt < 500) {
            $("#txtDesc").css("width")
        }
    });


});


function closeModal() {
    $("#overlay").hide();
    $("#ModalContent").html("");
    $("body").css("overflow", "hidden");
    return false;
}