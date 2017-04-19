
function solveProblem(args) {
    var a = +args[0];
	var b = +args[1];
	var c = +args[2];
		
    var numNegatives = 0;
	if (a < 0) {
		numNegatives += 1;
	}
	if (b < 0) {
		numNegatives += 1;
	}
	if (c < 0) {
		numNegatives += 1;
	}
	
	if (a === 0 || b === 0 || c === 0) {
		console.log('0');
	}
	else if (numNegatives === 1 || numNegatives === 3){
		console.log('-');
	}
	else {
		console.log('+');
	}
}
