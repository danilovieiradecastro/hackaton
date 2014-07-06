var custQuality = document.querySelector('.sliderQualityCustomized');
var initCust = new Powerange(custQuality, { hideRange: true, callback: changeQualityImage });

function changeQualityImage() {
    var changeInput = document.querySelector('.js-check-change');
    var imgSrc = "";
    var imgObj = document.getElementById("qualityImage");

    if (changeInput < 20)
        imgObj.src = '/Images/capeta.png';
    else if (changeInput > 20 && changeInput < 40)
        imgObj.src = '/Images/pega bebado.png';
    else if (changeInput > 40 && changeInput < 60)
        imgObj.src = '/Images/pegavel.png';
    else if (changeInput > 60 && changeInput < 80)
        imgObj.src = '/Images/bonita.png';
    else if (changeInput > 80)
        imgObj.src = '/Images/princesa.png';
    //alert('ok');
    // document.getElementById('js-display-decimal').innerHTML = dec.value;
}