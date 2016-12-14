
// Problem 1: Odd or Even

function solveProblem(args) {
	  var n = +args[0];
    var result = ((n % 2) === 0) ? ('even ' + n) : ('odd ' + n);

    jsConsole.writeLine(result);
    console.log(result);
}
