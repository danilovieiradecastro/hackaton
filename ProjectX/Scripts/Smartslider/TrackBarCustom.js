$(document).ready(function () {
    $('#trackbar1').strackbar({ callback: onTick1, defaultValue: 4, sliderHeight: 4, sliderWidth: 300, style: 'style1', animate: true, ticks: true, labels: true, trackerHeight: 20, trackerWidth: 19 });
});
function onTick1(value) {
    $('#text1').html("Current Value: " + value);
}