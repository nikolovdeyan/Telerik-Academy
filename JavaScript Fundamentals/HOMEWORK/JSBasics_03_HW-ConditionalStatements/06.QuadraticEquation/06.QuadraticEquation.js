
function solveProblem(args) {
    var a = +args[0],
		b = +args[1],
		c = +args[2];
		
	var x1 = (-b + (Math.sqrt(Math.pow(b, 2) - (4 * a * c)))) / (2 * a);
	var x2 = (-b - (Math.sqrt(Math.pow(b, 2) - (4 * a * c)))) / (2 * a);
	
	if (isNaN(x1) && isNaN(x2)) {
		console.log('no real roots');
	}
	else if (x1 === x2) {
		console.log('x1=x2=' + x1.toFixed(2));
	}
	else {
		console.log('x1=' + 
				   ((x1<x2) ? x1.toFixed(2) : x2.toFixed(2)) + 
					'; x2=' + 
				   ((x1<x2) ? x2.toFixed(2) : x1.toFixed(2)))
	}
}
