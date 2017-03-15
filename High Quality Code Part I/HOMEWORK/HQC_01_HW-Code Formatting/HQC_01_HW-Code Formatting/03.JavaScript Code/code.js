var appName,
    userAgent,
    addScroll = false,
    off = 0,
    event,
    theLayer,
    posX = 0,
    posY = 0;

appName = navigator.appName;
userAgent = navigator.userAgent;

if ((userAgent.indexOf('MSIE 5') > 0) || (userAgent.indexOf('MSIE 6')) > 0) {
  addScroll = true;
}

document.onmousemove = mouseMove;

if (appName === 'Netscape') {
  document.captureEvents(Event.MOUSEMOVE);
};

function mouseMove(evn) {
  if (appName === 'Netscape') {
    posX = evn.pageX - 5;
    posY = evn.pageY;

    if (document.layers['ToolTip'].visibility === 'show') {
      popTip();
    }
  } else {
    posX = event.x - 5;
    posY = event.y;

    if (document.all['ToolTip'].style.visibility === 'visible') {
      popTip();
    }
  }
}

function popTip() {
  if (appName == 'Netscape') {
    theLayer = document.layers['ToolTip'];

    if ((posX + 120) > window.innerWidth) {
      posX = window.innerWidth - 150;
    }

    theLayer.left = posX + 10;
    theLayer.top = posY + 15;
    theLayer.visibility = 'show';
  } else {
    theLayer = document.all['ToolTip'];

    if (theLayer) {
      posX = event.x - 5;
      posY = event.y;

      if (addScroll) {
        posX = posX + document.body.scrollLeft;
        posY = posY + document.body.scrollTop;
      }

      if ((posX + 120) > document.body.clientWidth) {
        posX = posX - 150;
      }

      theLayer.style.pixelLeft = posX + 10;
      theLayer.style.pixelTop = posY + 15;
      theLayer.style.visibility = 'visible';
    }
  }
}

function hideTip() {
  if (appName == "Netscape") {
    document.layers['ToolTip'].visibility = 'hide';
  } else {
    document.all['ToolTip'].style.visibility = 'hidden';
  }
}

function showMenu(menuName) {
  if (appName === 'Netscape') {
    theLayer = document.layers[menuName];
    theLayer.visibility = 'show';
  } else {
    theLayer = document.all[menuName];
    theLayer.style.visibility = 'visible';
  }
}

function hideMenu(menuName) {
  if (appName == "Netscape") {
    document.layers[menuName].visibility = 'hide';
  } else {
    document.all[menuName].style.visibility = 'hidden';
  }
}