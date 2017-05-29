## 06. Transact SQL
### _Homework_

---

##### 1. Create a database with two tables: `Persons(Id(PK), FirstName, LastName, SSN)` and `Accounts(Id(PK), PersonId(FK), Balance)`.
 - Insert few records for testing.
 - Write a stored procedure that selects the full names of all persons.
 
Preparing the database:
```sql
USE [master]
GO

CREATE DATABASE FinancesDatabase
ON
(
	NAME = FinancesDB_dat,
	FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\FinancesDB.mdf'    
)
LOG ON
(
	NAME = FinancesDB_log, 
	FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\FinancesDB.ldf'
);
GO

USE [FinancesDatabase]
GO

-- Create tables
CREATE TABLE Persons
(
	ID int IDENTITY NOT NULL PRIMARY KEY,
	FirstName nvarchar(50) NOT NULL,
	LastName nvarchar(50) NOT NULL,
	SSN nvarchar(30) NOT NULL,
)
GO

CREATE TABLE Accounts
(
	ID int IDENTITY NOT NULL PRIMARY KEY,
	PersonID int NOT NULL, 
	Balance money NOT NULL,
	CONSTRAINT FK_Accounts_Persons 
	    FOREIGN KEY(PersonID)
		REFERENCES Persons(ID)
)

-- Insert testing records
INSERT INTO Persons(FirstName, LastName, SSN)
VALUES
    ('Bill', 'Woolcott', 99181321588),
	('Charlton', 'Sennet', 99441917881),
	('Margaret', 'Case', 89168457791),
	('Sophie','Bangs', 89441737211),
	('Barbara','Shelley', 89426625692),
	('Stacia','Vanderveer', 89111149472),
	('Grace','Brannagh',89777819991);

INSERT INTO Accounts(PersonID, Balance)
VALUES
	(1, 100.00),
	(2, 755.25),
	(3, 10000.00),
	(4, 12768.55), 
	(5, 500.00),
	(6, 988.71),
	(7, 3.50);
```

Create the stored procedure:
```sql
CREATE PROC usp_GetFullNames
AS
	SELECT FirstName + ' ' + LastName AS [Full Name] 
	FROM Persons
GO
```

Execute the stored procedure:
```sql
EXEC usp_GetFullNames
```
 
Result:
 
|Full Name|
|---|
|Bill Woolcott|
|Charlton Sennet|
|Margaret Case|
|Sophie Bangs|
|Barbara Shelley|
|Stacia Vanderveer|
|Grace Brannagh|
 
--- 
 
##### 2. Create a stored procedure that accepts a number as a parameter and returns all persons who have more money in their accounts than the supplied number.

Create the stored procedure:
```sql
CREATE PROC usp_GetAccounsWithBalanceAboveLimit
(
	@limit money
)
AS
  SELECT p.FirstName + ' '  + p.LastName AS [Full Name],
		 a.Balance AS [Account Balance]
  FROM Persons p
	INNER JOIN Accounts a
    ON p.PersonID = a.AccountID
  WHERE a.Balance > @limit
GO
```

Execute the stored procedure:
```sql
EXEC usp_GetAccounsWithBalanceAboveLimit
    @limit = 500
GO
```

Result:

|Full Name|Account Balance|
|---|---|
|Charlton Sennet|755.25|
|Margaret Case|10000.00|
|Sophie Bangs|12768.55|
|Stacia Vanderveer|988.71|

--- 

##### 3. Create a function that accepts as parameters – sum, yearly interest rate and number of months.
 - It should calculate and return the new sum.
 - Write a `SELECT` to test whether the function works as expected.
 
Creating the function:
```sql
CREATE FUNCTION ufn_CalculateInterestRate
(
    @sum money,
	@yearlyInterestRate float,
	@numberOfMonths int
)
RETURNS money
AS
BEGIN
	RETURN @sum + (@sum * @yearlyInterestRate / 12 * @numberOfMonths) 
END
```
Testing the function:
```sql
SELECT ID AS [Account ID], 
       Balance AS [Balance Before Interest Applied],
	   dbo.ufn_CalculateInterestRate(Balance, 0.06, 12) AS [Balance After Interest Applied]
FROM Accounts
```

Result:

|Account ID|Balance Before Interest Applied|Balance After Interest Applied|
|---|---|---|
|1|100.00|106.00|
|2|755.25|800.565|
|3|10000.00|10600.00|
|4|12768.55|13534.663|
|5|500.00|530.00|
|6|988.71|1048.0326|
|7|3.50|3.71|

---
 
##### 4. Create a stored procedure that uses the function from the previous example to give an interest to a person's account for one month.
 - It should take the `AccountId` and the interest rate as parameters.
 
Creating the stored procedure:
```sql
CREATE PROC usp_ApplyMonthlyInterestRateToAccount
(
    @accountID int,
	@interestRate float
)
AS 
	UPDATE Accounts 
	SET Balance = dbo.ufn_CalculateInterestRate(Balance, @interestRate, 1)
FROM Accounts
WHERE ID = @accountID
GO
```

Using the stored procedure:
```sql
EXEC usp_ApplyMonthlyInterestRateToAccount
    @accountID = 1,
	@interestRate = 0.06
GO
```

---

##### 5. Add two more stored procedures `WithdrawMoney(AccountId, money)` and `DepositMoney(AccountId, money)` that operate in transactions.

Creating the stored procedure `WithdrawMoney`:
```sql
CREATE PROC usp_WithdrawMoney
(
    @accountID int,
	@sum money
)
AS
    UPDATE Accounts
	SET Balance = Balance - @sum
FROM Accounts
WHERE ID = @accountID
GO
```

Creating the stored procedure `DepositMoney`:
```sql
CREATE PROC usp_DepositMoney
(
    @accountID int,
	@sum money
)
AS
	UPDATE Accounts
	SET Balance = Balance + @sum
FROM Accounts
WHERE ID = @accountID
GO
```

Using the stored procedures:
```sql
EXEC usp_WithdrawMoney
    @accountID = 1,
	@sum = 50

EXEC usp_DepositMoney
    @accountID = 1,
	@sum = 1000
```

---

##### 6. Create another table – `Logs(LogID, AccountID, OldSum, NewSum)`.
 - Add a trigger to the `Accounts` table that enters a new entry into the `Logs` table every time the sum on an account changes.
 
Create the table:
```sql
CREATE TABLE Logs
(
	ID int IDENTITY NOT NULL PRIMARY KEY,
	AccountID int,
	OldSum money,
	NewSum money,
	CONSTRAINT FK_Logs_Accounts
	    FOREIGN KEY(AccountID)
		REFERENCES Accounts(ID)
)
GO
```

Add the trigger:
```sql
CREATE TRIGGER tr_DepositSumChange ON Accounts AFTER UPDATE
AS
INSERT INTO Logs
(
    AccountID,
	OldSum,
	NewSum
)
SELECT i.ID, d.Balance, i.Balance
FROM inserted i, deleted d
GO
```

Test the trigger:
```sql
EXEC usp_DepositMoney
    @accountID = 2,
	@sum = 750.50

EXEC usp_DepositMoney
    @accountID = 3,
	@sum = 100000

EXEC usp_WithdrawMoney
    @accountID = 3,
	@sum = 1550.49

SELECT * FROM Logs
```
 
Result:

|ID|AccountID|OldSum|NewSum|
|---|---|---|---|
|1|2|755.25|1505.75|
|2|3|10000.00|110000.00|
|3|3|110000.00|108449.51|

--- 

##### 7. Define a function in the database `TelerikAcademy` that returns all Employee's names (first or middle or last name) and all town's names that are comprised of given set of letters.
 - _Example_: '`oistmiahf`' will return '`Sofia`', '`Smith`', … but not '`Rob`' and '`Guy`'.
 
First create a helper scalar function returning a `bit` indicating if a passed string contains all the characters in a passed character set:
```sql
CREATE FUNCTION dbo.ufn_StringContainsCharacterSet
(
    @string nvarchar(50),
    @characterSet nvarchar(50)
)
RETURNS bit
AS
BEGIN
    DECLARE @index int = 1
	DECLARE @currentChar nvarchar(1)
	WHILE (@index <= LEN(@string))
		BEGIN
			SET @currentChar = SUBSTRING(@string, @index, 1)
			IF (CHARINDEX(LOWER(@currentChar), LOWER(@characterSet)) <= 0)
				RETURN 0
			SET @index = @index + 1
		END
	RETURN 1
END
GO
```
 
Testing the helper function `StringContainsCharacterSet`:
```sql
USE TelerikAcademy
SELECT Name FROM Towns WHERE [dbo].[ufn_StringContainsCharacterSet](Name, 'oistmiahf') = 1
```

Result: 

|Name|
|---|
|Sammamish|
|Sofia|
 
Create the filtering function to work with multiple merged columns:
```sql
CREATE Function dbo.ufn_FilterEmployeeAndCityNamesContainingCharacterSet
(
    @characterSet nvarchar(50)
)
RETURNS @result TABLE
    (
	[Name] nvarchar(50)
	)
AS
BEGIN
    INSERT @result
	SELECT [Name] FROM
	(
        SELECT Name FROM Towns
        UNION
        SELECT LastName FROM Employees
        UNION 
        SELECT MiddleName FROM Employees
        UNION 
        SELECT FirstName FROM Employees
	) as resultTable
	WHERE 
	    dbo.ufn_FilterNameContainingCharacterSet(resultTable.Name, @characterSet) = 1
		AND
		resultTable.Name IS NOT NULL
	RETURN
END
GO
```

Testing the result: 
```sql
SELECT * FROM ufn_FilterEmployeeAndCityNamesContainingCharacterSet('oiseltmiahf')
```

Result (first ten results shown): 

|Name|
|---|
|A|
|E|
|F|
|Fatima|
|H|
|Hall|
|Hao|
|Hee|
|Hesse|
|Hill|

---
 
##### 8. Using database cursor write a T-SQL script that scans all employees and their addresses and prints all pairs of employees that live in the same town.



---

##### 9. *Write a T-SQL script that shows for each town a list of all employees that live in it.
 - _Sample output_:	
```sql
Sofia -> Martin Kulov, George Denchev
Ottawa -> Jose Saraiva
…
```

---

##### 10. Define a .NET aggregate function `StrConcat` that takes as input a sequence of strings and return a single string that consists of the input strings separated by '`,`'.
 - For example the following SQL statement should return a single string:
```sql
SELECT StrConcat(FirstName + ' ' + LastName)
FROM Employees
```
