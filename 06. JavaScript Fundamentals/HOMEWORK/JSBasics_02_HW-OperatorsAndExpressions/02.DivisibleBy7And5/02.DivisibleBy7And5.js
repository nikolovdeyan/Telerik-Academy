
// Problem 2: Divide by 7 and 5

function solveProblem(args) {
    var n = +args[0];
    var nIsDivisible = (n % 7 === 0 && n % 5 === 0);
    var result = nIsDivisible + ' ' + n;

    jsConsole.writeLine(result);
    console.log(result);
}

