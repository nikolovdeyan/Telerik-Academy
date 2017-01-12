function solveProblem(args) {
    let myArr = [].slice.apply(args).map(Number);
    // We don't really need the first number, so we drop it.
    myArr.shift();
    // The last number is the one sought, so we pop and assign it.
    let soughtNum = myArr.pop();

    myArr.sort(function(a, b) {return a-b;});

    var isExisting = false;

    for (let i = 0; i < myArr.length; i += 1) {
        if (myArr[i] == soughtNum) {
            isExisting = true;
        }
    }

    if (!isExisting) {
        console.log("-1");
    }
    else {
        let imin = 0;
        let imax = myArr.length;

        while (imax >= imin) {
            let imid = imin + Math.floor((imax - imin) / 2);

            if (myArr[imid] === soughtNum) {
                console.log(imid);
                break;
            }
            else if (myArr[imid] < soughtNum) {
                imin = imid + 1;
            }
            else {
                imax = imid - 1;
            }
        }
    }
}
