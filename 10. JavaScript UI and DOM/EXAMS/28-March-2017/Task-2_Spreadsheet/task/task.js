function solve() {

	return function(selector, rows, columns) {
      function validateInputs(selector, rows, columns) {
          if (!rows || (typeof rows !== 'number')) {
              throw Error('rows should be a number');
          }
          if (rows <= 0) {
              throw Error('rows should be a positive number');
          }
          if (!columns || (typeof columns !== 'number')) {
              throw Error('columns should be a number');
          }
          if (columns <= 0) {
              throw Error('columns should be a positive number');
          }
          if (!selector || (typeof selector !== 'string')) {
              throw Error('Selector is not a string');
          }
      }

      rows = +rows + 1;
      columns = +columns + 1;

      validateInputs(selector, rows, columns);

      var selection = $(selector);
      var letters = ['', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H','I'	,'J',	'K',	'L',	'M',	'N',	'O',	'P',	'Q',	'R',	'S',	'T',	'U',	'V',	'W',	'X',	'Y',	'Z'];
      var table = $('<table>').addClass('spreadsheet-table');

      //var th = $('<th>').addClass('spreadsheet-header').addClass('spreadsheet-item');
      //var td = $('<td>').addClass('spreadsheet-cell').addClass('spreadsheet-item');
      
      for (var r = 0; r < rows; r += 1) {
          var tr = $('<tr>');

          // first row
          if (r === 0){
              for (var c = 0; c < columns; c += 1) {
                  var thfirst = $('<th>').addClass('spreadsheet-header').addClass('spreadsheet-item');
                  var letter = letters[c];
                  thfirst.html(letter);
                  thfirst.appendTo(tr);
              } 
          }
          // other rows
          else {
              for (var c1 = 0; c1 < columns; c1 += 1) {
                  var thnorm = $('<th>').addClass('spreadsheet-cell').addClass('spreadsheet-item');
                  if (c1 === 0) {
                      thnorm.html(r);
                  }
                  thnorm.appendTo(tr);
              }
          }


              tr.appendTo(table);
      }

      table.appendTo(selection);


	};
}