function locate() {
  let containerElement = document.getElementById('container');

  function getGeoLocationPosition() {
    return new Promise((resolve, reject) => {
      navigator.geolocation.getCurrentPosition(
        (position) => resolve(position),
        (error) => reject(error)
      );
    });
  }

  function parsePositionLongitudeAndLagitute(geolocationPosition) {
    if (geolocationPosition.coords) {
      return {
        latitude: geolocationPosition.coords.latitude,
        longitude: geolocationPosition.coords.longitude
      };
    } else {
      throw {
        message: "No coordinates element found",
        name: "UserException"
      };
    }
  }

  function createLocationImageGoogle(coordinates) {
    let imgGoogle = document.createElement('img'),
      imgSrcGoogle = "http://maps.googleapis.com/maps/api/staticmap?center=" +
      coordinates.latitude + "," +
      coordinates.longitude +
      "&zoom=13&size=500x500&sensor=false";

    imgGoogle.setAttribute('src', imgSrcGoogle);
    containerElement.appendChild(imgGoogle);
  }

    getGeoLocationPosition()
    .then(parsePositionLongitudeAndLagitute)
      .then(createLocationImageGoogle);
};

function redirect() {
  let containerElement = document.getElementById('container');
  const url = 'https://maps.google.com';

  function executeRedirect() {
    return new Promise((resolve, reject) => {
      resolve('You will be redirected to Google Maps in 2 seconds'),
      (error) => reject(error);
    });
  }

  function displayMessage(message) {
    containerElement.innerHTML = message;

    return url;
  }

  function delayRedirection(url){
    setInterval(function() {
      window.location.href = url;
    }, 2000);
  }

  executeRedirect()
    .then(displayMessage)
    .then(delayRedirection);
}
