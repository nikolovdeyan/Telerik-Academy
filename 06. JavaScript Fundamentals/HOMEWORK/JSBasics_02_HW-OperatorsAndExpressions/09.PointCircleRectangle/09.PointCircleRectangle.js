
// Problem 9: Point, Circle, Rectangle

function solveProblem(args) {
    var x = +args[0];
    var y = +args[1];

    // Given circle with x, y and r;
    var circle = [1.0, 1.0, 1.5];
    // Given rectangle with [x dimension] and [y dimension]
    var rectangle = [[-1.0, 5.0], [1.0, -1.0]];

    var pointToCircleCenter = Math.sqrt(Math.pow((x + (0 - circle[0])), 2) + Math.pow((y + (0 - circle[1])), 2));
    var inCircle = (pointToCircleCenter <= circle[2]) ? "inside circle " : "outside circle ";
    var inRectangle = (( x >= rectangle[0][0] && x <= rectangle[0][1] ) &&
                       ( y <= rectangle[1][0] && y >= rectangle[1][1] )) ? "inside rectangle" : "outside rectangle";

    jsConsole.writeLine(inCircle + inRectangle);
    console.log(inCircle + inRectangle);
}

