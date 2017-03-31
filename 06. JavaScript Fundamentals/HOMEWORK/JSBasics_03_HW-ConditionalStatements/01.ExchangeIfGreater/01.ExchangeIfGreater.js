
function solveProblem(args) {
    var a = +args[0],
        b = +args[1];

    if (a > b) {
        var t = b;
        b = a;
        a = t;
    }
	
    console.log(a, b);
}


