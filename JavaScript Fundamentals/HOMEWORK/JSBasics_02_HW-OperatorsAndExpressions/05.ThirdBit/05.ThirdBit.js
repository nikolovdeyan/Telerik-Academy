
// Problem 5: Third Bit

function solveProblem(args) {
    var n = +args[0];

    var nBase2 = '0' + ( n >>> 0 ).toString(2);
    //another way
    //console.log('0' + n.toString(2));

    var result = nBase2.slice(-3, -2);

    jsConsole.writeLine(result);
    console.log(result);
}

