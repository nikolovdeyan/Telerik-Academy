function alertIfBrowserIsMozilla(event, args) {
  var windowObject,
        browser,
        browserIsMozilla;

  windowObject = window;

  browser = windowObject.navigator.appCodeName;

  browserIsMozilla = (browser === "Mozilla");

    if (browserIsMozilla) {
        alert("Yes");
    } else {
        alert("No");
    }
}
