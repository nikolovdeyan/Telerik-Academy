
// Problem 4: Third Digit

function solveProblem(args) {
    var n = args[0];
    var thirdDigit = (n.slice(-3, -2) === '') ? '0' : n.slice(-3, -2);

    var result = (thirdDigit === '7') ? 'true' : ('false ' + thirdDigit);

    jsConsole.writeLine(result);
    console.log(result);
}

