function solveProblem(args) {

    function firstToBeTrue (arr) {
        for (var i = 1; i < arr.length - 1; i += 1) {
            if (largerThanNeighbour(arr, i)) {
                return i;
            }
        }
        return -1;
    }

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

    console.log(firstToBeTrue(numArr));
}


// TESTS

var test1 = ['6', '-26 -25 -28 31 2 27'];
solveProblem(test1);

var test2 = ['2', '2 3 4 5 4 1'];
solveProblem(test2);
