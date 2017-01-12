function solveProblem(args) {
    var n = +args[0];

    for (let i = n; i >= 0; i -= 1) {
        let isPrime = true;

        for (j = 2; j <= Math.sqrt(i); j += 1) {
            if (i % j === 0) {
                isPrime = false;
                break;
            }
        }

        if (isPrime === true) {
            console.log(i);
            break;
        }
    }
}
