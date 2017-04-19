function solveProblem(args) {

    function GetMax(numA, numB) {
        return ((numA >= numB) ? numA : numB);
    }

    var numbers = args[0].split(' ').map(Number);

    var firstNum = numbers[0],
        secondNum = numbers[1],
        thirdNum = numbers[2];

    var result = GetMax(firstNum, GetMax(secondNum, thirdNum));

    console.log(result);
}
