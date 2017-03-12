/* globals $ */
function solve() {
  return function (selector) {
    function eventHandler(e) {
      var target = e.target;
      var sibling = target.nextElementSibling;

      while(true) {

        if(sibling === null || sibling.className === 'button') {
          break;
        } else if(sibling.className === 'content') {

          if (!sibling.style.display ||
              sibling.style.display === '') {
            sibling.style.display = 'none';
            target.innerHTML = 'show';
          } else {
            sibling.style.display = '';
            target.innerHTML = 'hide';
          }
          break;

        } else {
          sibling = sibling.nextElementSibling;
          continue;
        }
      }

    };

    if(typeof(selector) === 'string'){
      selector = document.getElementById(selector);
    } else if (!(selector instanceof HTMLElement)) {
      throw Error('Provided selector is invalid');
    }

    var buttons = selector.getElementsByClassName('button');

    for(var i = 0, len = buttons.length; i < len; i += 1) {
      buttons[i].innerHTML = 'hide';
      buttons[i].addEventListener('click', eventHandler);
    }
  };
};

module.exports = solve;
