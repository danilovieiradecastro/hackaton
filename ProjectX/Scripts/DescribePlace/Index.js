$(document).ready(function () {

    var ratioValue = 3.26;

    $.fn.raty.defaults.path = '/Plugins/Raty/lib/images';
    $('#ratio').raty({ score: ratioValue, readOnly: true });

    $("#ratioValue").text(ratioValue);

});