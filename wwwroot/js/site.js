var isBasedonIP = true;
function GetIPAddressLocation()
{
    debugger;
    isBasedonIP = true;
    let clientUrlString = $("#clientDataUrl").val();
    $.getJSON("https://ipinfo.io/json?token=2d93f5ffce57e5", function (response) {
        GenerateWeatherDetails(response, clientUrlString)
    });
        
}
function GenerateWeatherDetails(data,url)
{
    debugger;
    $.ajax({
        url: url,
        data: (isBasedonIP == true? data : { dataDetails: data }),
        async: true,
        type: "GET",
        success: function (res) {
            $("#_weatherDetails").html(res);
        }
    }).done(function () {
        console.log("Done");
    });
}
function LoadLocationDetails(locationData)
{
    isBasedonIP = false;
    locationData.preventDefault();
    let strLocation = locationData.currentTarget[2].value;
    let clientUrlString = $("#locationDataUrl").val();
    GenerateWeatherDetails(strLocation, clientUrlString)
}
document.addEventListener('DOMContentLoaded', GetIPAddressLocation);
document.getElementById('frmLocation').addEventListener('submit', LoadLocationDetails);

