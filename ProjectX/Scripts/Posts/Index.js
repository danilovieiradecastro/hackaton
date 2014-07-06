$(document).ready(function () {

    $("#btnPostar").click(function () {
        $("#hdnAnonimo").val($("#cbAnonimo").is(":checked"));
        $("#hdnDescricao").val($("#txtDesc").text());
        $("#hdnLocal").val($("#ddPlace").val());

        $("#hdnPostar").trigger("click");
    });

    $("#linkAnexar").click(function () {

        $("#hdnImage").trigger("click");

    });

    $("#hdnImage").change(function () {
        readURL(this);
    });


    $("#DivImgPreview").mouseover(function () {
        var href = $("#imgPreview").attr("src");
        if (href != "#") {
            $("#imgPreview").css("opacity", "0.5");
            $("#closeImgPreview").show();
        }
    });

    $("#DivImgPreview").mouseout(function () {
        $("#imgPreview").css("opacity", "1");
        $("#closeImgPreview").hide();
    });

    $("#closeImgPreview").click(function () {

        $("#imgPreview").attr("src", "#");
        $(this).hide();
        $("#imgPreview").hide();
        $("#hdnImage").val("");

    });

});

function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            if (e.target.result == "") {
                $('#imgPreview').hide();
            } else {
                $('#imgPreview').attr('src', e.target.result);
                $('#imgPreview').prepend("<hr>");
                $('#imgPreview').show();
            }
        }

        reader.readAsDataURL(input.files[0]);
    }
}