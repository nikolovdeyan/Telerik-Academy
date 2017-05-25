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
	(SELECT MIN(Salary) FROM Employees)
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
	SELECT (MIN(Salary) * 1.1)
	FROM Employees
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
FROM Employees AS e
    JOIN Departments AS d
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
FROM Employees AS e
    JOIN Departments AS d
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
FROM Employees AS e
    JOIN Departments AS d
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
FROM Employees AS e
    JOIN Departments as d
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
FROM Employees AS e
    JOIN Employees as m
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
FROM Employees AS e
    JOIN Departments AS d
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
FROM Employees AS e
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
FROM Employees AS e
    INNER JOIN Employees AS m
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
FROM Employees as e
    LEFT OUTER JOIN Employees as m
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

Result:

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
SELECT * FROM Users
WHERE FORMAT(GETDATE(),'yyyymmdd') = FORMAT(LastLogin,'yyyymmdd')
```

Result:

|ID|UserName|Password|FullName|LastLogin|
|---|---|
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

-- Test the command and rollback. Then change ROLLBACK to COMMIT
SELECT * FROM Groups

ROLLBACK TRAN
```

Result:

|ID|Name|
|---|---|

---

##### 18. Write a SQL statement to add a column `GroupID` to the table `Users`.
 - Fill some data in this new column and as well in the `Groups table`.
 - Write a SQL statement to add a foreign key constraint between tables `Users` and `Groups` tables.
    
Query:
```sql

```

Result:



---

##### 19. Write SQL statements to insert several records in the `Users` and `Groups` tables.
    
Query:
```sql

```

Result:



---

##### 20. Write SQL statements to update some of the records in the `Users` and `Groups` tables.
    
Query:
```sql

```

Result:



---

##### 21. Write SQL statements to delete some of the records from the `Users` and `Groups` tables.
    
Query:
```sql

```

Result:



---

##### 22. Write SQL statements to insert in the `Users` table the names of all employees from the `Employees` table.
 - Combine the first and last names as a full name.
 - For username use the first letter of the first name + the last name (in lowercase).
 - Use the same for the password, and `NULL` for last login time.
    
Query:
```sql

```

Result:



---

##### 23. Write a SQL statement that changes the password to `NULL` for all users that have not been in the system since 10.03.2010.
    
Query:
```sql

```

Result:



---

##### 24. Write a SQL statement that deletes all users without passwords (`NULL` password).
    
Query:
```sql

```

Result:



---

##### 25. Write a SQL query to display the average employee salary by department and job title.
    
Query:
```sql

```

Result:



---

##### 26. Write a SQL query to display the minimal employee salary by department and job title along with the name of some of the employees that take it.
    
Query:
```sql

```

Result:



---

##### 27. Write a SQL query to display the town where maximal number of employees work.
    
Query:
```sql

```

Result:



---

##### 28. Write a SQL query to display the number of managers from each town.
    
Query:
```sql

```

Result:



---

##### 29. Write a SQL to create table `WorkHours` to store work reports for each employee (employee id, date, task, hours, comments).
 - Don't forget to define  identity, primary key and appropriate foreign key. 
 - Issue few SQL statements to insert, update and delete of some data in the table.
 - Define a table `WorkHoursLogs` to track all changes in the `WorkHours` table with triggers.
   - For each change keep the old record data, the new record data and the command (insert / update / delete).
    
Query:
```sql

```

Result:



---

##### 30. Start a database transaction, delete all employees from the '`Sales`' department along with all dependent records from the pother tables.
 - At the end rollback the transaction.
    
Query:
```sql

```

Result:



---

##### 31. Start a database transaction and drop the table `EmployeesProjects`.
 - Now how you could restore back the lost table data?
    
Query:
```sql

```

Result:



---

##### 32. Find how to use temporary tables in SQL Server.
 - Using temporary tables backup all records from `EmployeesProjects` and restore them back after dropping and re-creating the table.
    
Query:
```sql

```

Result:



---
