function solveProblem(args) {

    function MaximalElement(arr, startIndex) {
        var maxElement = arr[startIndex];
        var maxElementIndex;
        for (var i = startIndex + 1; i < arr.length; i += 1) {
            if (arr[i] > maxElement) {
                maxElement = arr[i];
                maxElementIndex = i;
            }
        }
        return maxElementIndex;
    }

    function SortArrayDescending(arr) {
        for (var i = 0; i < arr.length - 1; i += 1) {
            var tmp = arr[i];
            var largestNumIndex = MaximalElement(arr, i);

            if (largestNumIndex > 0) {
                arr[i] = arr[largestNumIndex];
                arr[largestNumIndex] = tmp;
            }
        }

        return arr;
    }

    function SortArrayAscending(arr) {
        SortArrayDescending(arr);
        for (var i = 0; i < Math.floor(arr.length / 2); i += 1) {
            var tmp = arr[i];
            arr[i] = arr[arr.length - 1 - i];
            arr[arr.length - 1- i] = tmp;
        }
        return arr;
    }

    var arrSize = +args[0];
    var numArr = args[1].split(' ').map(Number);
    var arrSorted = SortArrayAscending(numArr);
    console.log(arrSorted.join(' '));
}


// TESTS

var test1 = ['6', '3 4 1 5 2 6'];
solveProblem(test1);

var test2 = ['10', '36 10 1 34 28 38 31 27 30 20'];
solveProblem(test2);
