
// Problem 3: Typeof Variables
// Try typeof on all variables you created.

function solveProblem() {
	
	var integerLiteral = 5;
	var floatLiteral = 2.34;
	var stringLiteral = 'Pesho';
	var arrayLiteral = [1, 3, 5];
	var objectLiteral = { student: 'Ivan', studentNum: 123456 };
	var booleanLiteral = integerLiteral > floatLiteral;
	
	// Output for html page
	jsConsole.writeLine('<span class="var">integerLiteral</span> is of type <span class="type">' + (typeof integerLiteral) + '</span>');
	jsConsole.writeLine('<span class="var">floatLiteral</span> is of type <span class="type">' + (typeof floatLiteral) + '</span>');
	jsConsole.writeLine('<span class="var">stringLiteral</span> is of type <span class="type">' + (typeof stringLiteral) + '</span>');
	jsConsole.writeLine('<span class="var">arrayLiteral</span> is of type <span class="type">' + (typeof arrayLiteral) + '</span>');
	jsConsole.writeLine('<span class="var">objectLiteral</span> is of type <span class="type">' + (typeof objectLiteral) + '</span>');
	jsConsole.writeLine('<span class="var">booleanLiteral</span> is of type <span class="type">' + (typeof booleanLiteral) + '</span>');
	
	// Output for console
	console.log('integerLiteral is of type ' + (typeof integerLiteral));
	console.log('floatLiteral is of type ' + (typeof floatLiteral));
	console.log('stringLiteral is of type ' + (typeof stringLiteral));
	console.log('arrayLiteral is of type ' + (typeof arrayLiteral));
	console.log('objectLiteral is of type ' + (typeof objectLiteral));
	console.log('booleanLiteral is of type ' + (typeof booleanLiteral));
}