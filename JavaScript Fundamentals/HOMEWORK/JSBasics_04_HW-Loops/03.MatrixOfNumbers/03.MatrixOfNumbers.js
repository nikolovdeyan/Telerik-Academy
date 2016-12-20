function solveProblem(args) {
    var n = +args[0];
    var i;
    var j;
    var rowStr;

    // With nested loops:
    for (i = 1; i <= n; i+=1) {
        rowStr = '';
        for (j = i+1; j < n+i; j+=1) {
            rowStr = rowStr + ' ' + j;
        }
        console.log(i + rowStr);
    }
}


