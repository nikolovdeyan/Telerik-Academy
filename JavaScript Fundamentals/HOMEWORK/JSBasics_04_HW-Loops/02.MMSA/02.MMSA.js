function solveProblem(args) {
	
    // Convert the strings in the array to Number
    var arr = args.map(Number);
    var max;
    var min;
    var sum;
    var avg;

    // Using Function.prototype.apply()
    // func.apply(thisArg, [argsArray])
    // apply() calls a function with a given this value and arguments
    min = Math.min.apply(null, arr);
    max = Math.max.apply(null, arr);

    // Using Function.prototype.reduce()
    // Reduce() applies a function against an accumulator and each value of the array
    // from left to right to reduce it to a single value
    sum = arr.reduce(function(a, b) {return a + b;});
    avg = sum / arr.length;

    console.log('min=' + min.toFixed(2));
    console.log('max=' + max.toFixed(2));
    console.log('sum=' + sum.toFixed(2));
    console.log('avg=' + avg.toFixed(2));
}


