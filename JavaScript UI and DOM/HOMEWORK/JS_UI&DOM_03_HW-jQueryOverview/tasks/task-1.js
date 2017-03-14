/* global $ */

function solve() {
  return function (selector, count) {
    function validateInputs(selector, count) {
      // Validate count
      if (!count || (typeof count !== 'number')) {
        throw Error('count should be a number');
      }
      if (count <= 0) {
        throw Error('count should be a positive number');
      }
      // Validate selector
      if (!selector || (typeof selector !== 'string')) {
        throw Error('Selector is not a string');
      }
    }

    count = +count; 

    validateInputs(selector, count);

    var selection = $(selector);
    var ulFragment = $('<ul class="items-list"></ul>');
    var liFragment = $(new Array(count+1).join('<li class="list-item"></li>'));

    ulFragment.appendTo(selection);
    liFragment.appendTo($('.items-list'));

    $(".list-item").text(function(index) {
      return "List item #" + (index++);
    });
  };
};

module.exports = solve;
