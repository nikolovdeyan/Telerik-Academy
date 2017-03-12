/* globals $ */
function solve() {
  return function (selector) {

    function invalidSibling(element) {
      // Valid siblings include .button class
      return (element === null || element.className === 'button');
    }

    function contentIsHidden(element) {
      return (!element.style.display || element.style.display === '');
    }

    function showContent(element, target) {
      element.style.display = 'none';
      target.innerHTML = 'show';
    }

    function hideContent(element, target) {
      element.style.display = '';
      target.innerHTML = 'hide';
    }

    function eventHandler(e) {
      var target = e.target;
      var sibling = target.nextElementSibling;

      while(true) {

        if (invalidSibling(sibling)) {
          break;

        } else if (sibling.className === 'content') {
          if (contentIsHidden(sibling)) {
            showContent(sibling, target);
          } else {
            hideContent(sibling, target);
          }
          break;

        } else {
          sibling = sibling.nextElementSibling;
          continue;
        }
      }
    };

    function addEventListenerToButtons(buttons) {
      for(var i = 0, len = buttons.length; i < len; i += 1) {
        buttons[i].innerHTML = 'hide';
        buttons[i].addEventListener('click', eventHandler);
      }
    }

    if (typeof(selector) === 'string') {
      selector = document.getElementById(selector);
    }

    if (!(selector instanceof HTMLElement)) {
      throw Error('Provided selector is invalid');
    }

    var buttons = selector.getElementsByClassName('button');

    addEventListenerToButtons(buttons);
  };
};

module.exports = solve;
