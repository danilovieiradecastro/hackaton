$(document).ready(function () {
    
    var statusArray = ["Fraco", "Gato Pingado", "Mais ou Menos", "Cheio", "Bombando"];
    var posArray = ["0", "-30", "-60", "-90", "-120"];

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

});