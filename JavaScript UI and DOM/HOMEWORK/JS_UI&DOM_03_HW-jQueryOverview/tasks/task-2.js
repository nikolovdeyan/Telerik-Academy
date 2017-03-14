/* global $ jQuery*/
function solve() {
  return function (selector) {
    function onButtonClick() {
      // The next sibling that has either of the two classes
      var $sibling = $(this).nextAll('.button, .content').eq(0);
	  
      if ($sibling.hasClass('content') && $sibling.css('display') !== 'none') {
        $(this).html('show');
        $sibling.css('display', 'none');

      } else if ($sibling.hasClass('content') && $sibling.css('display') === 'none') {
        $(this).html('hide');
        $sibling.css('display', '');

      } else {
      }

    }

    if (typeof(selector) === 'string') {
      selector = $(selector);
    }

    if (selector.length === 0) {
      throw Error('Invalid selector provided');
    }

    selector.find(".button")
      .html('hide')
      .on("click", onButtonClick);
  };
};

module.exports = solve;
