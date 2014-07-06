$(document).ready(function () {

    $("#slider").slider({
        value: 20,
        min: 20,
        max: 100,
        step: 20,
        slide: function (event, ui) {
            $("#amount").val(ui.value);
        }
    });
    $("#amount").val($("#slider").slider("value"));

});