Notes on task 02.Events:

• /obj, /bin and /packages were deleted on submission of the homework. Restore the dependencies (PowerCollections) prior to building the project

• The task is operational. You can test it by using the commands below:
 
---------------------------------------------------------------------------------
AddEvent 2017-03-13A09:00:00 | MyTestEvent Number 1
AddEvent 2017-03-13P14:00:00 | MyTestEvent Number 2
AddEvent 2017-03-13P14:20:00 | MyTestEvent Number 3
AddEvent 2017-03-14A10:30:00 | MyTestEventWithLocation Number 4 | Sofia, Bulgaria
AddEvent 2017-03-15P15:30:00 | MyTestEventWithLocation Number 5 | Sofia, Bulgaria
DeleteEvents MyTestEvent Number 1
ListEvents 2017-03-13A09:00:00 | 3
End
---------------------------------------------------------------------------------

• The code has been refactored (I was using the Academy task from the C# OOP Exam as an inspiration):
	- the infinite loop and command handling has been moved into a singleton Engine class in /Core
	- the classes have been split in separate files and moved into /Models
	- interfaces were extracted for instantiated classes in /Contracts
	- constants and variables were extracted to minimize "magic numbers" usage in code
	- code has been arranged in accordance with StyleCop rules (namespace)
	- DateTime handling was improved -> Switched to ParseExact from Parse as the provided format is not typical
	- replaced the literal notation of empty strings with the .NET string.Empty and '/n' with Environment.NewLine

• Further possible improvements that i decided on not doing:
	- command parsing and extracting into an ICommand interface and separation of commands into classes
	- constants separation into a /Common namespaces and Constants class
	- XML documentation was omitted
	- string messages hardcoded in the Messages class were not extracted -- i thought it's more readable that way

Thanks for reviewing! =)
