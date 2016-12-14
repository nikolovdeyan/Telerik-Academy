
// Problem 8: Trapezoids

function solveProblem(args) {
    var a = +args[0];
    var b = +args[1];
    var h = +args[2];

    var area = (0.5 * (a + b) * h).toFixed(7);

    jsConsole.writeLine(area);
    console.log(area);
}

