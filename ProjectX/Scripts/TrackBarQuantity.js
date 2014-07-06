$(document).ready(function () {

    var valorStr = $("#hdnQuantidade").val();
    var valor = parseInt(valorStr);

    var statusArray = ["Fraco", "Gato Pingado", "Mais ou Menos", "Cheio", "Bombando"];
    var posArray = ["0", "-30", "-60", "-90", "-120"];

    alert(valorStr);

    if (valorStr != undefined) {
        $("#sliderQuantity").slider({
            value: valor,
            min: 20,
            max: 100,
            step: 20,
            disabled: true
        });
        $("#statusQuantity").text(statusArray[((parseInt(valor) / 10) / 2) - 1]);
        $("#divFaces").css("background-position-y", posArray[((parseInt(valor) / 10) / 2) - 1] + "px");
    }
    else {
        $("#sliderQuantity").slider({
            value: 20,
            min: 20,
            max: 100,
            step: 20,
            slide: function (event, ui) {
                $("#statusQuantity").text(statusArray[((parseInt(ui.value) / 10) / 2) - 1]);

                $("#divFaces").css("background-position-y", posArray[((parseInt(ui.value) / 10) / 2) - 1] + "px");
                $("#hdnQtd").val(ui.value);
            }
        });
        $("#statusQuantity").text(statusArray[((parseInt($("#sliderQuantity").slider("value")) / 10) / 2) - 1]);
    }
});