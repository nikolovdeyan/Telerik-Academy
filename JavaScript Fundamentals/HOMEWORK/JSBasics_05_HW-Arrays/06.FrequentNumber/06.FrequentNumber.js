function solveProblem(args) {
    let myArr = [].slice.apply(args).map(Number);
    // We don't really need the first number, so we drop it.
    myArr.shift();

    let frequency = {}; // Storing the counts
    let maxFrequency = 0;
    let maxElement; 

    for (let num in myArr) {
        // If the number exists in the new array, increment its result
        frequency[myArr[num]] = (frequency[myArr[num]] || 0) + 1;
        if (frequency[myArr[num]] > maxFrequency) {
            maxFrequency = frequency[myArr[num]];
            maxElement = myArr[num];
        }
    }
    console.log(maxElement + ' (' + maxFrequency + ' times)');
}
