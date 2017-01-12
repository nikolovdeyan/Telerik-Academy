function solveProblem(args) {

    let myArr = [].slice.apply(args).map(Number);
    // We don't really need the first number, so we drop it.
    myArr.shift();

    // Using Selection sort algorithm
    for (let i = 0; i < myArr.length; i += 1) {
        let min = i;

        for (let j = i + 1; j < myArr.length; j += 1) {
            if (myArr[j] < myArr[min]) {
                min = j;
            }
        }

        let temp = myArr[i];
        myArr[i] = myArr[min];
        myArr[min] = temp;
    }

    // Using Array.prototype.sort() <- Beware! it compares strings by default!
    // function sortNumber(a, b) {
    // return a - b;
    // }
    // myArr.sort(sortNumber);

    for (var elem of myArr){
        console.log(elem);
    }
}
