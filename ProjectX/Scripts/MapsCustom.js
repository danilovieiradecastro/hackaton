$(document).ready(function () { 
    var teste;
    var map;
    function initialize() {
        var mapOptions = {
            zoom: 15,
            center: new google.maps.LatLng(-21.763114, -43.353142)
        };
        var bounds = new google.maps.LatLngBounds();
        map = new google.maps.Map(document.getElementById('Map'), mapOptions);
        // Try HTML5 geolocation
        if(navigator.geolocation) {
            navigator.geolocation.getCurrentPosition(function(position) {
                var pos = new google.maps.LatLng(position.coords.latitude, position.coords.longitude);

                var infowindow = new google.maps.InfoWindow({
                    map: map,
                    position: pos,
                    content: 'Location found using HTML5.'
                });

                //map.setCenter(pos);
                //map.zoom(50);
                map.setCenter(pos);
            }, function() {
                handleNoGeolocation(true);
            });

        } else {
            // Browser doesn't support Geolocation
            handleNoGeolocation(false);
        }
    }

    google.maps.event.addDomListener(window, 'load', initialize);
});