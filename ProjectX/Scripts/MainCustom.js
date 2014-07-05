$(document).ready(function () {
    $("#btnDescribePlace").click(function () {
        
        $.post("/DescribePlace/RetornarViewAjax")
                .done(function (data) {
                    $("#overlay").show();
                    $("#ModalContent").html(data);
                });

        return false;
    });



});


function closeModal() {
    $("#overlay").hide();
    $("#ModalContent").hide();
}