$(document).ready(function () {

    var statusArray = ["Só Baranga", "Chapado eu Pego", "Mais ou Menos", "Gatinhas", "Pra Casar"];

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

});