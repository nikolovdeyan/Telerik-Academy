
// Problem 5: Third Bit

function solveProblem(args) {
    var n = +args[0];

    var nBase2 = '000' + n.toString(2);
    var result = nBase2.slice(-4, -3);

    jsConsole.writeLine(result);
    console.log(result);
}
