function solveProblem(args) {
    var arrSize = +args[0];
    var numArr = args[1].split(' ').map(Number);
    var numSought = +args[2];

    function countAppearence(num, arr) {
        var count = 0;
        for (var i = 0; i < arr.length; i += 1) {
            if (arr[i] == num) {
                count += 1;
            }
        }
        return count;
    }

    console.log(countAppearence(numSought, numArr));
}



// TESTS

var test1 = ['8', '28 6 21 6 -7856 73 73 -56', '73'];
solveProblem(test1);

