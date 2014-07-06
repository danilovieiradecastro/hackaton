$(document).ready(function () {

    $("#btnPostar").click(function () {
        $("#hdnAnonimo").val($("#cbAnonimo").val());
        $("#hdnDescricao").val($("#txtDesc").val());
        $("#hdnLocal").val($("#ddPlace").val());

        $("#hdnPostar").trigger("click");

        return false;
    });
});