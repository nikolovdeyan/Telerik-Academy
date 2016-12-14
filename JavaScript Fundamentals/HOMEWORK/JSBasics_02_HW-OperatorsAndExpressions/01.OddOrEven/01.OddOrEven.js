
// Problem 1: Odd or Even

function solveProblem(args) {
	  var n = +args[0];
    var result = 'odd ' + n;

    if( (n % 2) === 0 ){
        result = 'even ' + n;
    }

    jsConsole.writeLine(result);
    console.log(result);
}
