function getUserLocation() {
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(showLocation, errorHandler)
    } else {
        alert("Browser does not support geolocation services")
    }

}

function showLocation(location) {
    var latitude = location.coords.latitude;
    var longitude = location.coords.longitude;
    console.log(`Latitude: ${latitude}\nLongitude: ${longitude}`);
}

function errorHandler(error) {
    if (error.code == 1) {
        console.log("User denied location access")
    }
}