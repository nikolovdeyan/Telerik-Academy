
// Problem 1: JavaScript literals
// Assign all the possible JavaScript literals to different variables.

function solveProblem() {
	var intVar = 42;
	var floatVar = 0.05;
	var strVar = 'Hello, World!';
	var arrVar = [1, 3, 5];
	var objVar = { company: 'Boeing', model: '747-8I' };
	var boolVar = intVar > floatVar;
	
	// Output for html page
	jsConsole.writeLine('<span class="var">intVar</span> = <span class="val">' + intVar + '</span>');
	jsConsole.writeLine('<span class="var">floatVar</span> = <span class="val">' + floatVar + '</span>');
	jsConsole.writeLine('<span class="var">strVar</span> = <span class="val">' + strVar + '</span>');
	jsConsole.writeLine('<span class="var">arrVar</span> = <span class="val">' + arrVar  + '</span>');
	jsConsole.writeLine('<span class="var">objVar</span> = <span class="val">' + objVar.company + ' ' + objVar.model + '</span>');
	jsConsole.writeLine('<span class="var">boolVar</span> = <span class="val">' + boolVar + '</span>');
	
	// Output for console
	console.log('intVar = ' + intVar);
	console.log('floatVar = ' + floatVar);
	console.log('strVar = ' + strVar);
	console.log('arrVar = ' + arrVar);
	console.log('objVar = ' + objVar);
	console.log('boolVar = ' + boolVar);
}