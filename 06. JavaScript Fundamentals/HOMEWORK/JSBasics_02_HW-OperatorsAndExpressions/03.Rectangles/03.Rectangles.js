
// Problem 3: Rectangles

function solveProblem(args) {
    var a = +args[0],
        b = +args[1];

    var per = 2 * (a + b);
    var area = a * b;
    var result = area.toFixed(2) + ' ' + per.toFixed(2);

    jsConsole.writeLine(result);
    console.log(result);
}

