
function passToSolve() {
    var inputs = document.getElementById('problemInputs').value;
    var jsonstr = '[' + inputs.replace(/'/g, "\"") + ']';
    var arr = JSON.parse(jsonstr);

    solveProblem(arr);
}

