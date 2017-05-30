###### [My Telerik Academy Courses](https://github.com/nikolovdeyan/TelerikAcademy) 
---

## Advanced SQL 
### _Homework_

---
##### 1. Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company.
 - Use a nested `SELECT` statement.
    
Query:
```sql
SELECT FirstName + ' ' + LastName AS [Full Name], 
       Salary
FROM Employees
WHERE Salary = 
(
    SELECT MIN(Salary) FROM Employees
)
```

Result:

|Full Name|Salary|
|---|---|
|Susan Eaton|9000.00|
|Kim Ralls|9000.00|
|Jimmy Bischoff|9000.00|

---

##### 2. Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10% higher than the minimal salary for the company.
    
Query:
```sql
SELECT FirstName + ' ' + LastName AS [Full Name], 
       Salary
FROM Employees
WHERE Salary < 
(
    SELECT (MIN(Salary) * 1.1) FROM Employees
)
```

Result (first five results shown):

|Full Name|Salary|
|---|---|
|Steven Selikoff|9500.00|
|David Johnson|9500.00|
|Garrett Young|9500.00|
|Jian Shuo Wang|9500.00|
|Susan Eaton|9000.00|

---

##### 3. Write a SQL query to find the full name, salary and department of the employees that take the minimal salary in their department.
- Use a nested `SELECT` statement.
    
Query:
```sql
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
```

Result (first five results shown):

|Full Name|Dept. Name|Min. Dept. Salary|
|---|---|---|
|Gail Erickson|Engineering|32700.00|
|Jossef Goldberg|Engineering|32700.00|
|Sharon Salavaria|Engineering|32700.00|
|Thierry D'Hers|Tool Design|25000.00|
|Janice Galvin|Tool Design|25000.00|

---

##### 4. Write a SQL query to find the average salary in the department #1.
    
Query:
```sql
SELECT d.Name AS [Dept. Name],
       AVG(Salary) AS [Avg. Salary]
FROM Employees e
    JOIN Departments d
    ON e.DepartmentID = d.DepartmentID
WHERE d.DepartmentID = 1
GROUP BY d.Name
```

Result:

|Dept. Name|Avg. Salary|
|---|---|
|Engineering|40166.6666|

---

##### 5. Write a SQL query to find the average salary in the "Sales" department.
    
Query:
```sql
SELECT d.Name AS [Dept. Name],
       AVG(e.Salary) AS [Avg. Salary]
FROM Employees e
    JOIN Departments d
    ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'
GROUP BY d.Name
```

Result:

|Dept. Name|Avg. Salary|
|---|---|
|Sales|29988.8888|

---

##### 6. Write a SQL query to find the number of employees in the "Sales" department.
    
Query:
```sql
SELECT d.Name AS [Dept. Name],
       COUNT(*) AS [Num. Employees]
FROM Employees e
    JOIN Departments d
    ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'
GROUP BY d.Name
```

Result:

|Dept. Name|Num. Employees|
|---|---|
|Sales|18|

---

##### 7. Write a SQL query to find the number of all employees that have manager.
    
Query:
```sql
SELECT COUNT(*) AS [Employees With Manager]
FROM Employees
WHERE ManagerID IS NOT NULL
```

Another way (using a self-join):
```sql
SELECT COUNT(*) AS [Employees With Manager]
FROM Employees e
    JOIN Employees m
    ON e.ManagerID = m.EmployeeID
```

Result:

|Employees With Manager|
|---|
|289|

---

##### 8. Write a SQL query to find the number of all employees that have no manager.
    
Query:
```sql
SELECT COUNT(*) AS [Employees Without Manager]
FROM Employees
WHERE ManagerID IS NULL
```
Result:

|Employees Without Manager|
|---|
|4|

---

##### 9. Write a SQL query to find all departments and the average salary for each of them.
    
Query:
```sql
SELECT d.Name AS [Dept. Name],
       AVG(e.Salary) AS [Avg. Salary]
FROM Employees e
    JOIN Departments d
    ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name
ORDER BY d.Name
```

Result:

|Dept. Name|Avg. Salary|
|---|---|
|Document Control|14400.00|
|Engineering|40166.6666|
|Executive|92800.00|
|Facilities and Maintenance|13057.1428|
|Finance|23930.00|
|Human Resources|18016.6666|
|Information Services|34180.00|
|Marketing|14062.50|
|Production|14162.5698|
|Production Control|18683.3333|
|Purchasing|18983.3333|
|Quality Assurance|17542.8571|
|Research and Development|45542.8571|
|Sales|29988.8888|
|Shipping and Receiving|10866.6666|
|Tool Design|27150.00|

---

##### 10. Write a SQL query to find the count of all employees in each department and for each town.
    
Query:
```sql
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
```

Result (first ten results shown):

|Dept. Name|Town Name|Num. Employees|
|---|---|---|
|Document Control|Index|1|
|Document Control|Issaquah|4|
|Engineering|Bellevue|1|
|Engineering|Redmond|1|
|Engineering|Renton|4|
|Executive|Newport Hills|1|
|Executive|Renton|1|
|Facilities and Maintenance|Gold Bar|2|
|Facilities and Maintenance|Index|2|
|Facilities and Maintenance|Renton|3|

Another way to present the same information would be to use a _cross table_

---

##### 11. Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.
    
Query:
```sql
SELECT e.ManagerID,
       m.FirstName + ' ' +  m.LastName AS [Full Name],
       COUNT(*) AS [Num. Employees]
FROM Employees e
    INNER JOIN Employees m
    ON e.ManagerID = m.EmployeeID
GROUP BY e.ManagerID, m.FirstName, m.LastName
HAVING COUNT(*) = 5
```

Result:

|ManagerID|Full Name|Num. Employees|
|---|---|---|
|25|Zheng Mu|5|
|30|Paula Barreto de Mattos|5|
|64|Cristian Petculescu|5|
|85|Pilar Ackerman|5|
|123|Jeff Hay|5|
|159|Shane Kim|5|
|182|Katie McAskill-White|5|
|197|Lori Kane|5|

---

##### 12. Write a SQL query to find all employees along with their managers. For employees that do not have manager display the value "(no manager)".
    
Query:
```sql
SELECT e.FirstName + ' ' + e.LastName AS [Employee Name],
       COALESCE(m.FirstName + ' ' + m.LastName, 'no manager') AS [Manager Name]
FROM Employees e
    LEFT OUTER JOIN Employees m
    ON e.ManagerID = m.EmployeeID
```

Result (first five results shown):

|Employee Name|Manager Name|
|---|---|
|Ken Sanchez|no manager|
|Svetlin Nakov|no manager|
|Martin Kulov|no manager|
|George Denchev|no manager|
|Ovidiu Cracium|Roberto Tamburello|

---

##### 13. Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. Use the built-in `LEN(str)` function.

Query:
```sql
SELECT FirstName + ' ' + LastName AS [Employee Name]
FROM Employees
WHERE LEN(LastName) = 5
```

Result (first five results shown):

|Employee Name|
|---|
|Kevin Brown|
|Terri Duffy|
|Jo Brown|
|Diane Glimp|
|Peter Krebs|

---

##### 14. Write a SQL query to display the current date and time in the following format "`day.month.year hour:minutes:seconds:milliseconds`".
 - Search in Google to find how to format dates in SQL Server.
    
Query:
```sql
SELECT FORMAT(GETDATE(),'dd.MM.yyyy HH:mm:ss:f') AS [Current Time]
```

Result:

|Current Time|
|---|
|24.05.2017 22:19:06:6|

---

##### 15. Write a SQL statement to create a table `Users`. Users should have username, password, full name and last login time.
 - Choose appropriate data types for the table fields. Define a primary key column with a primary key constraint.
 - Define the primary key column as identity to facilitate inserting records.
 - Define unique constraint to avoid repeating usernames.
 - Define a check constraint to ensure the password is at least 5 characters long.
    
Query:
```sql
BEGIN TRAN

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

-- Test the command and rollback. Then change ROLLBACK to COMMIT
SELECT * FROM Users

ROLLBACK TRAN
```

Result:

|ID|UserName|Password|FullName|LastLogin|
|---|---|---|---|---|
|1|User|$5$MnfsQ4iN$ZMTppKN16y/tIsUYs/obHlhdP.Os80yXhTurpBMUbA5|User Sample|NULL|
|2|User2|$5$rounds=5000$usesomesillystri$KqJWpanXZHKq2BOB43TSaYhEWsQ1Lr5QNyPCDH/Tp.6 |User2 Sample|NULL|
|3|NewUser|7dc5c078dcd6d4b374b90a85d66ce0da4526773fb3844faab90300c2efa1fcb3|Todays User|2017-05-24 22:39:13.060|

--- 

##### 16. Write a SQL statement to create a view that displays the users from the `Users` table that have been in the system today.
 - Test if the view works correctly.
    
Query:
```sql
CREATE VIEW [SystemUsersToday] AS
SELECT * FROM Users
WHERE FORMAT(GETDATE(),'yyyyMMdd') = FORMAT(LastLogin,'yyyyMMdd')

SELECT * FROM SystemUsersToday
```

Result:

|ID|UserName|Password|FullName|LastLogin|
|---|---|---|---|---|
|3|NewUser|7dc5c078dcd6d4b374b90a85d66ce0da4526773fb3844faab90300c2efa1fcb3|Todays User|2017-05-24 22:44:31.110|

---

##### 17. Write a SQL statement to create a table `Groups`. Groups should have unique name (use unique constraint).
 - Define primary key and identity column.
    
Query:
```sql
BEGIN TRAN

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

-- Test the command and rollback. Then change ROLLBACK to COMMIT
SELECT * FROM Groups

ROLLBACK TRAN
```

Result:

|ID|Name|
|---|---|
|1|Admins|
|3|Inactive|
|2|Users|

---

##### 18. Write a SQL statement to add a column `GroupID` to the table `Users`.
 - Fill some data in this new column and as well in the `Groups table`.
 - Write a SQL statement to add a foreign key constraint between tables `Users` and `Groups` tables.
    
Query:
```sql
BEGIN TRAN

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

-- Test the command and rollback. Then change ROLLBACK to COMMIT
SELECT * FROM Users

ROLLBACK TRAN
```

Result:

|ID|UserName|Password|FullName|LastLogin|GroupID|
|---|---|---|---|---|---|
|1|User|$5$MnfsQ4iN$ZMTppKN16y/tIsUYs/obHlhdP.Os80yXhTurpBMUbA5|User Sample|NULL|1|
|2|User2|$5$rounds=5000$usesomesillystri$KqJWpanXZHKq2BOB43TSaYhEWsQ1Lr5QNyPCDH/Tp.6 |User2 Sample|NULL|2|
|3|NewUser|7dc5c078dcd6d4b374b90a85d66ce0da4526773fb3844faab90300c2efa1fcb3|Todays User|2017-05-27 10:40:25.927|2|

---

##### 19. Write SQL statements to insert several records in the `Users` and `Groups` tables.
    
Query:
```sql
BEGIN TRAN

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

-- Test the command and ROLLBACK. Then change ROLLBACK to COMMIT
SELECT * FROM Users
SELECT * FROM Groups
       
ROLLBACK TRAN
```

Result (Users):

|ID|UserName|Password|FullName|LastLogin|GroupID|
|---|---|---|---|---|---|
|1|User|$5$MnfsQ4iN$ZMTppKN16y/tIsUYs/obHlhdP.Os80yXhTurpBMUbA5|User Sample|NULL|1|
|2|User2|$5$rounds=5000$usesomesillystri$KqJWpanXZHKq2BOB43TSaYhEWsQ1Lr5QNyPCDH/Tp.6 |User2 Sample|NULL|2|
|3|NewUser|7dc5c078dcd6d4b374b90a85d66ce0da4526773fb3844faab90300c2efa1fcb3|Todays User|2017-05-27 13:33:18.917|2|
|10|RedOne|7849e1d65de0028a7da5901ac5004462f238e467fd37320ca5fa5e86c9379652|Reddd TheFirst |NULL|1|
|11|Leslie123|457af59805fa29a196a70ec12f0f042cd72e74dbee923b3204cc35d97c8956cf|Leslie Knope|2017-05-27 13:35:44.183|2|
|12|jerry|671b16ed98a14f053aac09447d6f51cadb3654c59b9f33ddfecb0fc4797879c0|Garry Gergich|2017-05-27 13:35:44.183|2|
|13|notme|fedb5532f2a52d5a646f6e05d1ffd1e73f630a97ee4efc232807b03b3cc62710|Ron Swanson|2017-05-27 13:35:44.183|2|
|14|tom|0bddce0a2102d6b93d1300908df4919e5a647940e495e748ac883687f2746f2b|Tom Haverford|2017-05-27 13:35:44.183|2|
|15|benwyatt|e8be84604783a904831cc91e68396c06eee57340caf097e235e3faf4976c3e6a|Ben Wyatt|2017-05-27 13:35:44.183|2|

Result (Groups):

|ID|Name|
|---|---|
|1|Admins|
|3|Inactive|
|7|Legacy|
|6|Managers|
|2|Users|

---

##### 20. Write SQL statements to update some of the records in the `Users` and `Groups` tables.
    
Query:
```sql
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
```

Result:

|UserName|Password|FullName|LastLogin|GroupID|
|---|---|---|---|---|
|notme|fedb5532f2a52d5a646f6e05d1ffd1e73f630a97ee4efc232807b03b3cc62710|Ron Swanson|2017-05-27 11:07:34.410|6|

---

##### 21. Write SQL statements to delete some of the records from the `Users` and `Groups` tables.
    
Query:
```sql
DELETE FROM Users
WHERE ID = 1

DELETE FROM Groups
WHERE Name = 'Legacy'
```

---

##### 22. Write SQL statements to insert in the `Users` table the names of all employees from the `Employees` table.
 - Combine the first and last names as a full name.
 - For username use the first letter of the first name + the last name (in lowercase).
 - Use the same for the password, and `NULL` for last login time.
    
 - Creating a function that will return a unique user name:
```sql
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
```

 - Creating a function that will return a unique password, and will fill the password up to the constraint's requirement:
 ```sql
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
```
 - Using the created functions to complete the required modifications:
 ```sql
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
```

Result: 

|ID|UserName|Password|FullName|LastLogin|GroupID|
|---|---|---|---|---|---|
|129|abarbariol|abarbariol|Angela Barbariol|NULL|2|
|154|aberglund|aberglund|Andreas Berglund|NULL|2|
|179|abrewer|abrewer|Alan Brewer|NULL|2|
|220|acencini|acencini|Andrew Cencini|NULL|2|
|45|aciccu|aciccu|Alice Ciccu|NULL|2|
|40|amcguel|amcguel|Alejandro McGuel|NULL|2|
|164|anayberg|anayberg|Alex Nayberg|NULL|2|
|194|andhill|andhill|Andrew Hill|NULL|2|
|273|annhill|annhill|Annette Hill|NULL|2|
|207|arao|_arao|Arvind Rao|NULL|2|

---

##### 23. Write a SQL statement that changes the password to `NULL` for all users that have not been in the system since 10.03.2010.
    
Query:
```sql
UPDATE Users
SET [Password] = NULL
WHERE [LastLogin] < CONVERT(DATETIME, '2010-03-10')
```

---

##### 24. Write a SQL statement that deletes all users without passwords (`NULL` password).
    
Query:
```sql
BEGIN TRAN 

DELETE FROM Users
WHERE Password IS NULL

SELECT * FROM Users

ROLLBACK TRAN
```

---

##### 25. Write a SQL query to display the average employee salary by department and job title.
    
Query:
```sql
SELECT d.Name AS [Department], 
       e.JobTitle AS [Job Title],
       AVG(e.Salary) AS [Avg Salary]
FROM Employees e
    INNER JOIN Departments d
    ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle
ORDER BY d.Name
```

Result (first five results shown):

|Department|Job Title|Avg Salary|
|---|---|---|
|Document Control|Control Specialist|16800.00|
|Document Control|Document Control Assistant|10300.00|
|Document Control|Document Control Manager|17800.00|
|Engineering|Design Engineer|32700.00|
|Engineering|Engineering Manager|43300.00|

---

##### 26. Write a SQL query to display the minimal employee salary by department and job title along with the name of some of the employees that take it.
    
Query:
```sql
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
```

Result (first ten results shown):

|Dept. Name|Minimal Salary|JobTitle|ExampleEmployee|
|---|---|---|---|
|Document Control|16800.00|Control Specialist|Chris Norred|
|Document Control|10300.00|Document Control Assistant|Sean Chai|
|Document Control|17800.00|Document Control Manager|Zainal Arifin|
|Engineering|32700.00|Design Engineer|Gail Erickson|
|Engineering|43300.00|Engineering Manager|Roberto Tamburello|
|Engineering|36100.00|Senior Design Engineer|Michael Sullivan|
|Engineering|63500.00|Vice President of Engineering|Terri Duffy|
|Executive|125500.00|Chief Executive Officer|Ken Sanchez|
|Executive|60100.00|Chief Financial Officer|Laura Norman|
|Facilities and Maintenance|9800.00|Facilities Administrative Assistant|Magnus Hedlund|

---

##### 27. Write a SQL query to display the town where maximal number of employees work.
    
Query:
```sql
SELECT TOP 1 t.Name AS [Maximum Occupancy Office], 
       COUNT(*) AS [Employees Count]
FROM Employees e
    JOIN Addresses a
    ON a.AddressID = e.AddressID
	    JOIN Towns t
	    ON a.TownID = t.TownID
GROUP BY t.Name
ORDER BY [Employees Count] DESC
```

Result:

|Maximum Occupancy Office|Employees Count|
|---|---|
|Seattle|44|

---

##### 28. Write a SQL query to display the number of managers from each town.
    
Query:
```sql
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
```

Result:

|City Name|Managers Count|
|---|---|
|Seattle|10|
|Redmond|5|
|Kenmore|5|
|Bellevue|4|
|Renton|4|

---

##### 29. Write a SQL to create table `WorkHours` to store work reports for each employee (employee id, date, task, hours, comments).
 - Don't forget to define  identity, primary key and appropriate foreign key. 
 - Issue few SQL statements to insert, update and delete of some data in the table.
 - Define a table `WorkHoursLogs` to track all changes in the `WorkHours` table with triggers.
   - For each change keep the old record data, the new record data and the command (insert / update / delete).
    
Creating the WorkHours Table:
```sql
BEGIN TRAN

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

ROLLBACK TRAN
```

---

##### 30. Start a database transaction, delete all employees from the '`Sales`' department along with all dependent records from the pother tables.
 - At the end rollback the transaction.
    
Query:
```sql
BEGIN TRAN

ALTER TABLE Departments
DROP CONSTRAINT FK_Departments_Employees

DELETE FROM Employees
WHERE DepartmentID =
    (
    SELECT DepartmentID FROM Departments
    WHERE Name = 'Sales'
    )

ROLLBACK TRAN
```

---

##### 31. Start a database transaction and drop the table `EmployeesProjects`.
 - Now how you could restore back the lost table data?
    
>> Use BEGIN TRAN / ROLLBACK TRAN / COMMIT TRAN for all transactions that modify the database structure
    
---

##### 32. Find how to use temporary tables in SQL Server.
 - Using temporary tables backup all records from `EmployeesProjects` and restore them back after dropping and re-creating the table.
    
Query:
```sql
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
```
---
