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

});


function closeModal() {
    $("#overlay").hide();
    $("#ModalContent").html("");
    $("body").css("overflow", "hidden");
    return false;
}