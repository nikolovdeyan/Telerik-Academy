
// Problem 6: Point in a Circle

function solveProblem(args) {
    var x = +args[0];
    var y = +args[1];

    var distancePoint = Math.sqrt(Math.pow(x, 2) + Math.pow(y, 2));
    var result = (distancePoint <= 2) ? ("yes " + distancePoint.toFixed(2)) : ("no " + distancePoint.toFixed(2));

    jsConsole.writeLine(result);
    console.log(result);
}

