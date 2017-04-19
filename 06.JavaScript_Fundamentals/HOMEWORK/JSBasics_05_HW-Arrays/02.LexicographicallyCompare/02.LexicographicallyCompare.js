
function solveProblem(args) {

    let firstStr = args[0];
    let secondStr = args[1];

    if(firstStr > secondStr) {
        console.log('>');
    }
    else if (firstStr < secondStr) {
        console.log('<');
    }
    else {
        console.log('=');
    }
}
