function solveProblem(args) {
    var n = +args[0];
    var i;
    var result = '';

    for (i = 1; i <= n; i += 1) {
        result = result + ' ' + i;
    }
    console.log(result);
}


