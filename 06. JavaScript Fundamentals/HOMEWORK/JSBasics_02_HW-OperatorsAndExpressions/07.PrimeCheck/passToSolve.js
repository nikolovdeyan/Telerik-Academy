
function passToSolve() {
    var inputs = document.getElementById('problemInputs').value;
    var jsonstr = '[' + inputs.replace(/'/g, "\"") + ']';
    var arr = JSON.parse(jsonstr);

    // arr = [["First line of input"], ["Second line of input"]]
    solveProblem(arr[0]);
}

