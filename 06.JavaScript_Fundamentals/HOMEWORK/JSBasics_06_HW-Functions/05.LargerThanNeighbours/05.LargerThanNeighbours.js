function solveProblem(args) {

    function largerThanNeighbour(arr, index) {
        if ((arr[index] > arr[index-1]) && (arr[index] > arr[index+1])) {
            return true;
        }
        else {
            return false;
        }
    }

    var arrSize = +args[0];
    var numArr = args[1].split(' ').map(Number);
    var counter = 0;

    for (var i = 1; i < numArr.length - 1; i += 1) {
        if (largerThanNeighbour(numArr, i)){
            counter += 1;
        }
    }


    console.log(counter);
}


// TESTS

var test1 = ['6', '-26 -25 -28 31 2 27'];
solveProblem(test1);

