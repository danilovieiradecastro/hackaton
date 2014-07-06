$(document).ready(function () {

    var valorStr = $("#hdnQualidade").val();
    var valor = parseInt(valorStr);

    var statusArray = ["Só Baranga", "Chapado eu Pego", "Mais ou Menos", "Gatinhas", "Pra Casar"];

    
    if (valorStr != undefined) {
        
        $("#slider").slider({
            value: valor,
            min: 20,
            max: 100,
            step: 20,
            disabled: true
        });
        $("#imgFace").attr("src", "/Images/faces/" + valor + ".png");
        $("#status").text(statusArray[((valor / 10) / 2) - 1]);
    } else {
        $("#slider").slider({
            value: 20,
            min: 20,
            max: 100,
            step: 20,
            slide: function (event, ui) {
                $("#status").text(statusArray[((parseInt(ui.value) / 10) / 2) - 1]);
                $("#imgFace").attr("src", "/Images/faces/" + ui.value + ".png");
                $("#hdnQld").val(ui.value);
            }
        });
        $("#status").text(statusArray[((parseInt($("#slider").slider("value")) / 10) / 2) - 1]);
    }
});