Notes on Naming Identifiers Homework:




• The task is operational. You can test it by using the commands below:

• The code has been refactored :
	- Created static class Minesweeper to hold the game logic.
	- No invocations of the method 'smetki' exist in the code, so the method was removed.
	- Logic to initialize/reset round was extracted in SetupNewRound() method as it was repeated multiple times
	- Logic to count number of surrounding mines was improved:
		-- long chain of if clauses rewritten according to this approach (http://stackoverflow.com/a/5802694/6819519)
	- Logic to parse user input as Row/Col parameters was extracted in ParseCommand() method.


• Further possible improvements that i decided on not doing:


Thanks for reviewing! =)
