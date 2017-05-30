USE TelerikAcademy

-- 01. Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company.
--     - Use a nested SELECT statement.

SELECT FirstName + ' ' + LastName AS [Full Name], 
       Salary
FROM Employees
WHERE Salary = 
	(
        SELECT MIN(Salary) FROM Employees
    )

-- 02. Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10% higher than the minimal salary for the company.

SELECT FirstName + ' ' + LastName AS [Full Name], 
       Salary
FROM Employees
WHERE Salary < 
	(
	SELECT (MIN(Salary) * 1.1) FROM Employees
	)

-- 03. Write a SQL query to find the full name, salary and department of the employees that take the minimal salary in their department.
--     - Use a nested SELECT statement.

SELECT FirstName + ' ' + LastName AS [Full Name],
       d.Name AS [Dept. Name],
       Salary AS [Min. Dept. Salary]
FROM Employees e
    JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
WHERE Salary = 
	(
	SELECT MIN(Salary)
	FROM Employees
	WHERE DepartmentID = e.DepartmentID
	)

-- 04. Write a SQL query to find the average salary in the department #1.

SELECT d.Name AS [Dept. Name],
       AVG(Salary) AS [Avg. Salary]
FROM Employees e
    JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
WHERE d.DepartmentID = 1
GROUP BY d.Name

-- 05. Write a SQL query to find the average salary in the "Sales" department.

SELECT d.Name AS [Dept. Name],
       AVG(e.Salary) AS [Avg. Salary]
FROM Employees e
    JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'
GROUP BY d.Name

-- 06. Write a SQL query to find the number of employees in the "Sales" department.

SELECT d.Name AS [Dept. Name],
     COUNT(*) AS [Num. Employees]
FROM Employees e
    JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'
GROUP BY d.Name

-- 07. Write a SQL query to find the number of all employees that have manager.

SELECT COUNT(*) AS [Employees With Manager]
FROM Employees
WHERE ManagerID IS NOT NULL

-- OR

SELECT COUNT(*) AS [Employees With Manager]
FROM Employees e
    JOIN Employees m
	ON e.ManagerID = m.EmployeeID

-- 08. Write a SQL query to find the number of all employees that have no manager.

SELECT COUNT(*) AS [Employees Without Manager]
FROM Employees
WHERE ManagerID IS NULL

-- 09. Write a SQL query to find all departments and the average salary for each of them.

SELECT d.Name AS [Dept. Name],
       AVG(e.Salary) AS [Avg. Salary]
FROM Employees e
    JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name
ORDER BY d.Name

-- 10. Write a SQL query to find the count of all employees in each department and for each town.

SELECT d.Name as [Dept. Name], 
       t.Name as [Town Name], 
	   COUNT(*) as [Num. Employees]
FROM Employees e
	INNER JOIN Departments d
    ON e.DepartmentID = d.DepartmentID
		INNER JOIN Addresses a
		ON e.AddressID = a.AddressID 
			INNER JOIN Towns t
			ON a.TownID = t.TownID
GROUP BY d.Name, t.Name
ORDER BY d.Name

-- 11. Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.

SELECT e.ManagerID,
       m.FirstName + ' ' +  m.LastName AS [Full Name],
       COUNT(*) AS [Num. Employees]
FROM Employees e
    INNER JOIN Employees m
	ON e.ManagerID = m.EmployeeID
GROUP BY e.ManagerID, m.FirstName, m.LastName
HAVING COUNT(*) = 5

-- 12. Write a SQL query to find all employees along with their managers. For employees that do not have manager display the value "(no manager)".

SELECT e.FirstName + ' ' + e.LastName AS [Employee Name],
       COALESCE(m.FirstName + ' ' + m.LastName, 'no manager') AS [Manager Name]
FROM Employees e
    LEFT OUTER JOIN Employees m
    ON e.ManagerID = m.EmployeeID

-- 13. Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. Use the built-in LEN(str) function.

SELECT FirstName + ' ' + LastName AS [Employee Name]
FROM Employees
WHERE LEN(LastName) = 5

-- 14. Write a SQL query to display the current date and time in the following format "`day.month.year hour:minutes:seconds:milliseconds`".
--     - Search in Google to find how to format dates in SQL Server.

SELECT FORMAT(GETDATE(),'dd.MM.yyyy HH:mm:ss:f') AS [Current Time]

-- 15. Write a SQL statement to create a table `Users`. Users should have username, password, full name and last login time.

CREATE TABLE Users
(
	ID int IDENTITY,
	[UserName] varchar(20) NOT NULL,
	[Password] varchar(100) NOT NULL,
	[FullName] varchar(50) NOT NULL,
	[LastLogin] dateTime,
	CONSTRAINT PK_Users PRIMARY KEY(ID),
	CONSTRAINT UK_UserName UNIQUE(UserName),
	CONSTRAINT Check_Password CHECK(LEN([Password])>=5)
)

INSERT INTO Users (UserName, [Password], FullName, LastLogin)
VALUES ('User', '$5$MnfsQ4iN$ZMTppKN16y/tIsUYs/obHlhdP.Os80yXhTurpBMUbA5', 'User Sample', NULL);
        
INSERT INTO Users (UserName, [Password], FullName, LastLogin)
VALUES ('User2', '$5$rounds=5000$usesomesillystri$KqJWpanXZHKq2BOB43TSaYhEWsQ1Lr5QNyPCDH/Tp.6 ', 'User2 Sample', NULL);

INSERT INTO Users (UserName, [Password], FullName, LastLogin)
VALUES ('NewUser', '7dc5c078dcd6d4b374b90a85d66ce0da4526773fb3844faab90300c2efa1fcb3', 'Todays User', GETDATE());

-- 16. Write a SQL statement to create a view that displays the users from the `Users` table that have been in the system today.
--     - Test if the view works correctly.

CREATE VIEW [V_SystemUsersToday] AS
SELECT * FROM Users
WHERE FORMAT(GETDATE(),'yyyyMMdd') = FORMAT(LastLogin,'yyyyMMdd')

-- 17. Write a SQL statement to create a table `Groups`. Groups should have unique name (use unique constraint).
--     - Define primary key and identity column.

CREATE TABLE Groups
(
  [ID] int IDENTITY,
  [Name] nvarchar(100) NOT NULL,
  CONSTRAINT PK_Groups PRIMARY KEY(ID),
  CONSTRAINT UK_Name UNIQUE(Name)
)

INSERT INTO Groups (Name)
VALUES ('Admins');

INSERT INTO Groups (Name)
VALUES ('Users');

INSERT INTO Groups (Name)
VALUES ('Inactive');

SELECT * FROM Groups

-- 18. Write a SQL statement to add a column `GroupID` to the table `Users`.
--     - Fill some data in this new column and as well in the `Groups table`.
--     - Write a SQL statement to add a foreign key constraint between tables `Users` and `Groups` tables.

ALTER TABLE Users
ADD GroupID int
GO

ALTER TABLE Users
ADD CONSTRAINT FK_Users_Groups
FOREIGN KEY(GroupID)
REFERENCES Groups(ID)

-- Updating already existing users with a GroupID
UPDATE Users SET GroupID = 1 WHERE ID = 1
UPDATE Users SET GroupID = 2 WHERE ID = 2
UPDATE Users SET GroupID = 2 WHERE ID = 3

SELECT * FROM Users

-- 19. Write SQL statements to insert several records in the `Users` and `Groups` tables.

INSERT INTO Users ([UserName], [Password], [FullName], [LastLogin], [GroupID])
VALUES ('RedOne', '7849e1d65de0028a7da5901ac5004462f238e467fd37320ca5fa5e86c9379652', 'Reddd TheFirst', NULL, 1),
		('Leslie123', '457af59805fa29a196a70ec12f0f042cd72e74dbee923b3204cc35d97c8956cf', 'Leslie Knope', GETDATE(), 2),
		('jerry', '671b16ed98a14f053aac09447d6f51cadb3654c59b9f33ddfecb0fc4797879c0', 'Garry Gergich', GETDATE(), 2),
		('notme', 'fedb5532f2a52d5a646f6e05d1ffd1e73f630a97ee4efc232807b03b3cc62710', 'Ron Swanson', GETDATE(), 2),
		('tom', '0bddce0a2102d6b93d1300908df4919e5a647940e495e748ac883687f2746f2b', 'Tom Haverford', GETDATE(), 2),
		('benwyatt', 'e8be84604783a904831cc91e68396c06eee57340caf097e235e3faf4976c3e6a', 'Ben Wyatt', GETDATE(), 2);

INSERT INTO Groups ([Name])
VALUES ('Managers'),
       ('Legacy')

SELECT * FROM Users
SELECT * FROM Groups

-- 20. Write SQL statements to update some of the records in the `Users` and `Groups` tables.

UPDATE Users 
SET GroupID = g.ID
FROM 
(
    SELECT ID, Name 
    FROM Groups 
    WHERE Name = 'Managers'
) g
WHERE UserName = 'notme'

SELECT * FROM Users WHERE UserName = 'notme'

-- 21. Write SQL statements to delete some of the records from the `Users` and `Groups` tables.

DELETE FROM Users
WHERE ID = 1

DELETE FROM Groups
WHERE Name = 'Legacy'

-- 22. Write SQL statements to insert in the `Users` table the names of all employees from the `Employees` table.
--     - Combine the first and last names as a full name.
--     - For username use the first letter of the first name + the last name (in lowercase).
--     - Use the same for the password, and `NULL` for last login time.

-- A helper function to produce deduplicated user name
CREATE FUNCTION ufn_GetDeduplicatedUserName
(
    @firstName nvarchar(100),
	@lastName nvarchar(100)
)
RETURNS nvarchar(100)
AS
BEGIN
	DECLARE @firstNameCharsToTake int = 1;
	DECLARE @userName nvarchar(100);
	DECLARE @isUniqueUserName bit = 0;
	DECLARE @occurances int;

	WHILE (@isUniqueUserName = 0)
	    BEGIN
		    SET @userName = LEFT(LOWER(@firstName), @firstNameCharsToTake) + LOWER(@lastName);

			SELECT @occurances = [Occurances] FROM
			(
				SELECT
				LEFT(LOWER(e.FirstName), @firstNameCharsToTake) + LOWER(e.LastName) AS [UserName],
				Count(*) AS [Occurances]
				FROM Employees e
				GROUP BY LEFT(LOWER(e.FirstName), @firstNameCharsToTake) + LOWER(e.LastName)
			) as r
			WHERE r.UserName = @userName;

			IF (@occurances = 1)
				SET @isUniqueUserName = 1;
			ELSE
				SET @firstNameCharsToTake = @firstNameCharsToTake + 1;
		END;
	RETURN @userName;
END;
GO

CREATE FUNCTION ufn_GetDeduplicatedPassword
(
    @firstName nvarchar(100),
	@lastName nvarchar(100)
)
RETURNS nvarchar(100)
AS
BEGIN
	DECLARE @minPasswordLength int = 5
	DECLARE @firstNameCharsToTake int = 1;
	DECLARE @userName nvarchar(100);
	DECLARE @isUniqueUserName bit = 0;
	DECLARE @occurances int;

	WHILE (@isUniqueUserName = 0)
	    BEGIN
		    SET @userName = LEFT(LOWER(@firstName), @firstNameCharsToTake) + LOWER(@lastName);

			SELECT @occurances = [Occurances] FROM
			(
				SELECT
				LEFT(LOWER(e.FirstName), @firstNameCharsToTake) + LOWER(e.LastName) AS [UserName],
				Count(*) AS [Occurances]
				FROM Employees e
				GROUP BY LEFT(LOWER(e.FirstName), @firstNameCharsToTake) + LOWER(e.LastName)
			) as r
			WHERE r.UserName = @userName;


			IF (LEN(@userName) <= @minPasswordLength)
			    SET @userName = REPLICATE('_', (@minPasswordLength - LEN(@userName))) + @userName;

			IF (@occurances = 1)
				SET @isUniqueUserName = 1;
			ELSE
				SET @firstNameCharsToTake = @firstNameCharsToTake + 1;
		END;
	RETURN @userName;
END;
GO

INSERT INTO Users 
(
    [UserName], 
    [Password], 
    [FullName], 
    [LastLogin], 
	[GroupID]
)
SELECT 
    dbo.ufn_GetDeduplicatedUserName(e.FirstName, e.LastName),
    dbo.ufn_GetDeduplicatedPassword(e.FirstName, e.LastName),
    e.FirstName + ' ' + e.LastName,
    Null,
    2
FROM Employees e
GO

SELECT * FROM Users ORDER BY UserName

-- 23. Write a SQL statement that changes the password to `NULL` for all users that have not been in the system since 10.03.2010.

UPDATE Users
SET [Password] = NULL
WHERE [LastLogin] < CONVERT(DATETIME, '2010-03-10')

-- 24. Write a SQL statement that deletes all users without passwords (`NULL` password).

DELETE FROM Users
WHERE Password IS NULL

SELECT * FROM Users

-- 25. Write a SQL query to display the average employee salary by department and job title.

SELECT d.Name AS [Department], 
       e.JobTitle AS [Job Title],
	   AVG(e.Salary) AS [Avg Salary]
FROM Employees e
	INNER JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle
ORDER BY d.Name

-- 26. Write a SQL query to display the minimal employee salary by department and job title along with the name of some of the employees that take it.

SELECT d.Name as [Dept. Name],
       MIN(Salary) AS [Minimal Salary],
       JobTitle,
       ExampleEmployee = 
	   (
	        SELECT TOP 1 FirstName + ' ' + LastName 
	        FROM Employees e 
	        WHERE
			( 
				e.Salary = MIN(m.Salary)
				AND
				e.JobTitle = m.JobTitle
			)
			ORDER BY NEWID() -- Gets a random match
	   )
FROM Employees m
	JOIN Departments d
	ON m.DepartmentID = d.DepartmentID 
GROUP BY d.Name, m.JobTitle
ORDER BY d.Name

-- 27. Write a SQL query to display the town where maximal number of employees work.

SELECT TOP 1 t.Name AS [Maximum Occupancy Office], 
       COUNT(*) AS [Employees Count]
FROM Employees e
JOIN Addresses a
	ON a.AddressID = e.AddressID
JOIN Towns t
	ON a.TownID = t.TownID
GROUP BY t.Name
ORDER BY [Employees Count] DESC

-- 28. Write a SQL query to display the number of managers from each town.

SELECT t.Name AS [City Name], 
       COUNT(DISTINCT e.ManagerID) AS [Managers Count]
FROM Employees e
    JOIN Employees m
	ON e.ManagerID = m.EmployeeID
        JOIN Addresses a
	    ON a.AddressID = m.AddressID
            JOIN Towns t
	        ON a.TownID = t.TownID
GROUP BY t.Name
ORDER BY [Managers Count] DESC

-- 29. Write a SQL to create table `WorkHours` to store work reports for each employee (employee id, date, task, hours, comments).
--     - Don't forget to define  identity, primary key and appropriate foreign key. 
--     - Issue few SQL statements to insert, update and delete of some data in the table.
--     - Define a table `WorkHoursLogs` to track all changes in the `WorkHours` table with triggers.
--       - For each change keep the old record data, the new record data and the command (insert / update / delete).

CREATE TABLE WorkHours 
(
	[ID] int IDENTITY,
	[EmployeeID] int NOT NULL,
	[Date] datetime,
	[Task] nvarchar(100),
	[Hours] int,
	[Comments] nvarchar(500),
	CONSTRAINT PK_WorkHours PRIMARY KEY(ID),
	CONSTRAINT FK_WorkHours_Employees FOREIGN KEY(EmployeeID)
	REFERENCES Employees(EmployeeID)
)
GO

INSERT INTO WorkHours([EmployeeID], [Date], [Task], [Hours], [Comments])
VALUES
	(2, GETDATE(),'Scrum Meeting', 2, 'Kick-off Aviatto Project'),
	(3, GETDATE(),'Scrum Meeting', 1, 'Kick-off Aviatto Project'),
	(4, GETDATE(),'PTO', 8, 'Holiday'),
	(5, GETDATE(),'Task11', 4, 'Working on feature 11');

UPDATE WorkHours SET [Hours] = 2 WHERE [EmployeeID] = 3

DELETE FROM WorkHours WHERE Task='PTO'

CREATE TABLE WorkHoursLogs 
(
	[ID] int IDENTITY,
	[WorkHoursID] int,
	[EmployeeID] int NOT NULL,
	[Date] datetime,
	[Task] nvarchar(100),
	[Hours] int,
	[Comments] nvarchar(500),
	[Command] nvarchar(30) NOT NULL,
	CONSTRAINT PK_WorkHoursLogs PRIMARY KEY(ID),
	CONSTRAINT FK_WorkHoursLogs_Employees FOREIGN KEY(EmployeeID)
	REFERENCES Employees(EmployeeID)
)
GO

CREATE TRIGGER TR_WorhoursInsert ON WorkHours FOR INSERT
AS
INSERT INTO WorkHoursLogs(WorkHoursID, EmployeeID, [Date], Task, [Hours], Comments, Command)
SELECT  ID, EmployeeID, [Date], Task, [Hours], Comments, 'INSERT'
FROM inserted
GO

CREATE TRIGGER TR_WorhoursUpdate ON WorkHours FOR UPDATE
AS
INSERT INTO WorkHoursLogs(WorkHoursID, EmployeeID, [Date], Task, [Hours], Comments, Command)
SELECT ID, EmployeeID, [Date], Task, [Hours], Comments, 'UPDATE'
FROM inserted
GO

CREATE TRIGGER TR_WorhoursDelete ON WorkHours FOR DELETE
AS
INSERT INTO WorkHoursLogs(WorkHoursID, EmployeeID, [Date], Task, [Hours], Comments, Command)
SELECT ID, EmployeeID, [Date], Task, [Hours], Comments, 'DELETE'
FROM deleted
GO

INSERT INTO WorkHours([EmployeeID], [Date], [Task], [Hours], [Comments])
VALUES
(10, GETDATE(),'Insert Trigger 1', 2, 'Testing insert trigger'),
(11, GETDATE(),'Insert Trigger 2', 4, 'Testing insert trigger again')

UPDATE WorkHours
SET Task = 'Update Trigger 1'
WHERE EmployeeID = 11

DELETE FROM WorkHours
WHERE EmployeeID = 11

SELECT * FROM WorkHoursLogs

-- 30. Start a database transaction, delete all employees from the '`Sales`' department along with all dependent records from the pother tables.
--     - At the end rollback the transaction.

ALTER TABLE Departments
DROP CONSTRAINT FK_Departments_Employees

DELETE FROM Employees
WHERE DepartmentID =
	(
	SELECT DepartmentID FROM Departments
	WHERE Name = 'Sales'
	)

-- 31. Start a database transaction and drop the table `EmployeesProjects`.
--     - Now how you could restore back the lost table data?


-- 32. Find how to use temporary tables in SQL Server.
--     - Using temporary tables backup all records from `EmployeesProjects` and restore them back after dropping and re-creating the table.

SELECT * 
INTO #MyTempTable
FROM EmployeesProjects
GO

DROP TABLE EmployeesProjects
GO

CREATE TABLE EmployeesProjects(
[EmployeeID] INT NOT NULL,
[ProjectID] INT NOT NULL,
CONSTRAINT FK_EmployeesProjects_Employees FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID),
CONSTRAINT FK_EmployeesProjects_Projects FOREIGN KEY (ProjectID) REFERENCES Projects(ProjectID)
)
GO

INSERT INTO EmployeesProjects
SELECT * FROM #MyTempTable