
// Problem 4. Typeof Null
// Create null, undefined variables and try typeof on them.

function solveProblem() {
	
	var nullVar = null;
	var undefVar = undefined;
	var emptyVar;

	// Output for html page
	jsConsole.writeLine('The null variable <span class="var">nullVar</span> is of type <span class="type">' + (typeof nullVar)+ '</span>');
	jsConsole.writeLine('The variable <span class="var">undefVar</span> is declared as undefined and is of type <span class="type">' + (typeof undefVar)+ '</span>');
	jsConsole.writeLine('The variable <span class="var">emptyVar</span> has no initialization and is of type <span class="type">' + (typeof emptyVar)+ '</span>');

	// Output for console
	console.log('The null variable nullVar is of type ' + (typeof nullVar) );
	console.log('The variable undefVar is initialized as undefined and is of type ' + (typeof undefVar));
	console.log('The variable emptyVar has no initialization and is of type ' + (typeof emptyVar));
}