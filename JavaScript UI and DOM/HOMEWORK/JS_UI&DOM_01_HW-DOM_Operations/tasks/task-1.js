/* globals $ */

/* 

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed   
*/

function solve() {
  return function(selector, contents) {
    function validateInputs(element, contents) {
      if (!(element instanceof HTMLElement)) {
        throw Error('Provided element should be a string or HTML Element');
      }

      if (contentsHasInvalidItems(contents)) {
        throw Error('Provided contents array has invalid items');
      }
    }

    function parseIdAsDomElement(element) {
      if (typeof(element) === 'string') {
        element = document.getElementById(element);
      }

      return element;
    }

    function contentsHasInvalidItems(contents) {
      if (!contents || contents.some(function(item) {
        return (typeof (item) !== 'string' &&
                typeof (item) !== 'number');
      })) {
        return true;
      } else {
        return false;
      }
    }

    //function prepareNewElementES2016(contents) {
    //  var newFragment = document.createDocumentFragment();
    //
    //  contents.forEach(item => {
    //  var contentsDiv = document.createElement('div');
    //    contentsDiv.innerHTML = item;
    //    newFragment.appendChild(contentsDiv);
    //  });
    //
    //  return newFragment;
    //}

    function prepareNewElement(contents) {
      var newFragment = document.createDocumentFragment();

      for (var i = 0, len = contents.length; i < len; i += 1) {
        var contentsDiv = document.createElement('div');
        contentsDiv.innerHTML = contents[i];
        newFragment.appendChild(contentsDiv);
      }

      return newFragment;
    }

    function replaceElementWithContents(element, contents) {
      element.innerHTML = '';
      element.appendChild(contents);
    }

    var element = parseIdAsDomElement(selector);

    validateInputs(element, contents);

    // ES2016 currently not supported in bgcoder
    // var newElement = prepareNewElementES2016(contents);
    var newElement = prepareNewElement(contents);

    replaceElementWithContents(element, newElement);
  };
}

module.exports = solve;

