###### [My Telerik Academy Courses](https://github.com/nikolovdeyan/TelerikAcademy) 
---

## Structured Query Language (SQL)
### _Homework_

---

##### What is SQL? What is DML? What is DDL? Recite the most important SQL commands.

Structured Query Language is a computer language specialized for managing data held in relational databases, which makes it a domain-specific language (DSL). SQL consists of:
 - Data Definition Language (DDL) -- Syntax for defining data structures, especially database schemas. Most important commands: `CREATE`, `ALTER`, `DROP`
 - Data Manipulation Language (DML) -- Syntax for selecting, inserting, deleting and updating data in a database. Most important commands: `SELECT`, `INSERT`, `UPDATE`, `DELETE`
 - Data Control Language (DCL) -- Syntax used to control access to data stored in a database. Most important commands: `GRANT`, `REVOKE`

---

##### What is Transact-SQL (T-SQL)?

Transact-SQL or T-SQL is a proprietary extension to the SQL by Microsoft and Sybase. It expands on the SQL to include procedures, local variables, functions, etc. It is central to using Microsoft SQL Server. 

---

##### Start SQL Management Studio and connect to the database TelerikAcademy. Examine the major tables in the "TelerikAcademy" database.

Major tables: `Addresses`, `Departments`, `Employees`, `EmployeesProjects`, `Projects`, `Towns`

---

##### Write a SQL query to find all information about all departments (use "TelerikAcademy" database).

Query: 
```sql
SELECT * FROM  Departments
```

Result:

|DepartmentID|Name|ManagerID|
|---|
|1|Engineering|12|
|2|Tool Design|4|
|3|Sales|273|
|4|Marketing|46|
|5|Purchasing|6|
|6|Research and Development|42|
|7|Production|148|
|8|Production Control|21|
|9|Human Resources|30|
|10|Finance|3|
|11|Information Services|42|
|12|Document Control|90|
|13|Quality Assurance|274|
|14|Facilities and Maintenance|218|
|15|Shipping and Receiving|85|
|16|Executive|109|

---

##### Write a SQL query to find all department names.

Query: 
```sql
SELECT Name FROM  Departments
```

Result:
|Name|
|---|
|Engineering|
|Tool Design|
|Sales|
|Marketing|
|Purchasing|
|Research and Development|
|Production|
|Production Control|
|Human Resources|
|Finance|
|Information Services|
|Document Control|
|Quality Assurance|
|Facilities and Maintenance|
|Shipping and Receiving|
|Executive|

---

##### Write a SQL query to find the salary of each employee.

Query:
```sql
 SELECT FirstName + ' ' + LastName AS 'Full Name', 
 Salary FROM Employees
```

Result (first five results shown):
|Full Name|Salary|
|---|
|Guy Gilbert|12500.00|
|Kevin Brown|13500.00|
|Roberto Tamburello|43300.00|
|Rob Walters|29800.00|
|Thierry D'Hers|25000.00|

---

##### Write a SQL to find the full name of each employee.

Query:
```sql
SELECT FirstName + ' ' + LastName AS 'Full Name' FROM Employees
```


Result (first five results shown):
|Full Name|
|---|
|Guy Gilbert|
|Kevin Brown|
|Roberto Tamburello|
|Rob Walters|
|Thierry D'Hers|

---

##### Write a SQL query to find the email addresses of each employee (by his first and last name). Consider that the mail domain is telerik.com. Emails should look like “John.Doe@telerik.com". The produced column should be named "Full Email Addresses".

Query:
```sql
SELECT FirstName + '.' + LastName + '@telerik.com' 
AS 'Full Email Address' 
FROM Employees
```

Result (first five results shown):
|Full Email Address|
|---|
|Guy.Gilbert@telerik.com|
|Kevin.Brown@telerik.com|
|Roberto.Tamburello@telerik.com|
|Rob.Walters@telerik.com|
|Thierry.D'Hers@telerik.com|

---

##### Write a SQL query to find all different employee salaries.

Query:
```sql
SELECT DISTINCT Salary
FROM Employees
ORDER BY Salary DESC
```

Result:
|Salary|
|---|
|125500.00|
|84100.00|
|72100.00|
|63500.00|
|60100.00|

---

##### Write a SQL query to find all information about the employees whose job title is “Sales Representative“.

Query:
```sql
SELECT * 
FROM Employees
WHERE JobTitle = 'Sales Representative'
```

Result (first five results shown):
|EmployeeID|FirstName|LastName|MiddleName|JobTitle|DepartmentID|ManagerID|HireDate|Salary|AddressID|
|---|
|275|Michael|Blythe|G|Sales Representative|3|268|2003-07-01 00:00:00|23100.00|60|
|276|Linda|Mitchell|C|Sales Representative|3|268|2003-07-01 00:00:00|23100.00|170|
|277|Jillian|Carson|NULL|Sales Representative|3|268|2003-07-01 00:00:00|23100.00|61|
|278|Garrett|Vargas|R|Sales Representative|3|268|2003-07-01 00:00:00|23100.00|52|
|279|Tsvi|Reiter|Michael|Sales Representative|3|268|2003-07-01 00:00:00|23100.00|154|

---

##### Write a SQL query to find the names of all employees whose first name starts with "SA".

Query:
```sql
SELECT * 
FROM Employees
WHERE FirstName LIKE 'SA%'
```

Result (first five results):

|EmployeeID|FirstName|LastName|MiddleName|JobTitle|DepartmentID|ManagerID|HireDate|Salary|AddressID|
|---|
|46|Sariya|Harnpadoungsataya|E|Marketing Specialist|4|6|2001-01-13 00:00:00|14400.00|106|
|73|Sandra|Reategui Alayo|NULL|Production Technician|7|135|2001-01-27 00:00:00|9500.00|255|
|132|Sairaj|Uddin|L|Scheduling Assistant|8|44|2001-02-27 00:00:00|16000.00|190|
|151|Samantha|Smith|H|Production Technician|7|108|2001-03-08 00:00:00|14000.00|14|
|165|Sameer|Tejani|A|Production Technician|7|74|2001-03-15 00:00:00|11000.00|66|

----------------------

##### Write a SQL query to find the names of all employees whose last name contains "ei".

Query: 
```sql
SELECT *
FROM Employees
WHERE LastName LIKE '%ei%'
```

Result (first five results)

|EmployeeID|FirstName|LastName|MiddleName|JobTitle|DepartmentID|ManagerID|HireDate|Salary|AddressID|
|---|
|29|Kendall|Keil|C|Production Technician|7|14|2001-01-06 00:00:00|11000.00|257|
|49|Christian|Kleinerman|E|Maintenance Supervisor|14|218|2001-01-15 00:00:00|20400.00|118|
|79|Diane|Margheim|L|Research and Development Engineer|6|158|2001-01-30 00:00:00|40900.00|111|
|157|Brandon|Heidepriem|G|Production Technician|7|16|2001-03-12 00:00:00|12500.00|189|
|222|Brian|Goldstein|Richard|Production Technician|7|51|2002-01-12 00:00:00|15000.00|48|

---

##### Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].

Query: 
```sql
SELECT FirstName, LastName, Salary
FROM Employees
WHERE Salary BETWEEN 20000 AND 30000
``` 

Result: 
|FirstName|LastName|Salary|
|------|
|Rob|Walters|29800.00|
|Thierry|D'Hers|25000.00|
|JoLynn|Dobney|25000.00|
|Taylor|Maxwell|25000.00|
|Jo|Brown|25000.00|

---

##### Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.

Query: 
```sql
SELECT FirstName + ' ' + LastName AS 'Full Name',
	   Salary
FROM Employees
WHERE Salary in (25000, 14000, 12500, 23600)
```
Result (firt five results shown): 
|Full Name|Salary|
|---|
|Guy Gilbert|12500.00|
|Thierry D'Hers|25000.00|
|JoLynn Dobney|25000.00|
|Taylor Maxwell|25000.00|
|Jo Brown|25000.00|

---

##### Write a SQL query to find all employees that do not have manager.

Query: 
```sql
SELECT * FROM Employees 
WHERE ManagerID IS NULL
``` 

Result:
|FirstName|LastName|
|---|
|Ken|Sanchez|
|Svetlin|Nakov|
|Martin|Kulov|
|George|Denchev|

---

##### Write a SQL query to find all employees that have salary more than 50000. Order them in decreasing order by salary.

Query: 
```sql
SELECT FirstName, LastName, Salary
FROM Employees
WHERE Salary > 50000
ORDER BY Salary DESC
``` 

Result (first five results shown): 
|FirstName|LastName|Salary|
|---|
|Ken|Sanchez|125500.00|
|James|Hamilton|84100.00|
|Brian|Welcker|72100.00|
|Terri|Duffy|63500.00|
|Laura|Norman|60100.00|

---

##### Write a SQL query to find the top 5 best paid employees.

Query: 
```sql
SELECT TOP 5 
FirstName, LastName, Salary
FROM Employees
ORDER BY Salary DESC
``` 

Result: 
|FirstName|LastName|Salary|
|---|
|Ken|Sanchez|125500.00|
|James|Hamilton|84100.00|
|Brian|Welcker|72100.00|
|Terri|Duffy|63500.00|
|Laura|Norman|60100.00|

---

##### Write a SQL query to find all employees along with their address. Use inner join with `ON` clause.

Query: 
```sql
SELECT e.FirstName + ' ' + e.LastName AS 'Full Name',
	   a.AddressText AS 'Address'
FROM Employees AS e
JOIN Addresses AS a
    ON e.AddressID = a.AddressID
``` 

Result (first five results shown): 
|Full Name|Address|
|---|
|Andy Ruth|108 Lakeside Court|
|Paula Barreto de Mattos |1343 Prospect St|
|Russell King|1648 Eastgate Lane|
|Shammi Mohamed|2284 Azalea Avenue|
|Linda Moschell|2947 Vine Lane|

---

##### Write a SQL query to find all employees and their address. Use equijoins (conditions in the `WHERE` clause).

Query: 
```sql
SELECT e.FirstName + '' + e.LastName AS 'Full Name',
	   a.AddressText AS 'Address'
FROM Employees AS e, Addresses AS a
WHERE e.AddressID = a.AddressID
``` 

Result (first five results shown): 
|Full Name|Address|
|---|
|AndyRuth|108 Lakeside Court|
|PaulaBarreto de Mattos|1343 Prospect St|
|RussellKing|1648 Eastgate Lane|
|ShammiMohamed|2284 Azalea Avenue|
|LindaMoschell|2947 Vine Lane|

---

##### Write a SQL query to find all employees along with their manager.

Query: 
```sql
SELECT e.FirstName + ' ' + e.LastName AS 'Full Name',
       m.FirstName + ' ' + m.LastName AS 'Manager Name'
FROM Employees AS e
JOIN Employees AS m
    ON e.ManagerID = m.EmployeeID
``` 

Result (first five results shown): 
|Full Name|Manager Name|
|---|
|Ovidiu Cracium|Roberto Tamburello|
|Michael Sullivan|Roberto Tamburello|
|Sharon Salavaria|Roberto Tamburello|
|Dylan Miller|Roberto Tamburello|
|Rob Walters|Roberto Tamburello|

---

##### Write a SQL query to find all employees, along with their manager and their address. Join the 3 tables: `Employees e`, `Employees m` and `Addresses a`.

Query: 
```sql
SELECT e.FirstName + ' ' + e.LastName AS 'Full Name',
       m.FirstName + ' ' + m.LastName AS 'Manager Name',
	   a.AddressText AS 'Manager Address'
FROM Employees AS e
	JOIN Employees AS m
	ON e.ManagerID = m.EmployeeID
		JOIN Addresses as a
		ON m.AddressID = a.AddressID
``` 

Result: 
|Full Name|Manager Name|Manager Address|
|---|
|Rob Walters|Roberto Tamburello|8000 Crane Court|
|Gail Erickson|Roberto Tamburello|8000 Crane Court|
|Jossef Goldberg|Roberto Tamburello|8000 Crane Court|
|Dylan Miller|Roberto Tamburello|8000 Crane Court|
|Ovidiu Cracium|Roberto Tamburello|8000 Crane Court|

---

##### Write a SQL query to find all departments and all town names as a single list. Use `UNION`.

Query: 
```sql
SELECT Name FROM Departments
UNION
SELECT Name FROM Towns
``` 

Result (first five results shown): 
|Name|
|---|
|Bellevue|
|Berlin|
|Bordeaux|
|Bothell|
|Calgary|

---

##### Write a SQL query to find all the employees and the manager for each of them along with the employees that do not have manager. Use right outer join. Rewrite the query to use left outer join.

Query: 
```sql
SELECT m.FirstName + ' ' + m.LastName AS 'Manager Name',
       e.FirstName + ' ' + e.LastName AS 'Employee Name'
FROM Employees AS m
    RIGHT OUTER JOIN Employees AS e
    ON e.ManagerID = m.EmployeeID
``` 

Query rewritten with left outer join:
```sql
SELECT e.FirstName + ' ' + e.LastName AS 'Employee Name',
       m.FirstName + ' ' + m.LastName AS 'Manager name'
FROM Employees AS e
    LEFT OUTER JOIN Employees AS m
    ON e.ManagerID = m.EmployeeID
```

Result: 
|Manager Name|Employee Name|
|---|
|NULL|Ken Sanchez|
|NULL|Svetlin Nakov|
|NULL|Martin Kulov|
|NULL|George Denchev|
|Roberto Tamburello|Ovidiu Cracium|

---

##### Write a SQL query to find the names of all employees from the departments "Sales" and "Finance" whose hire year is between 1995 and 2005.

Query: 
```sql
SELECT e.FirstName + ' ' + e.LastName AS 'Full Name', 
       d.Name as 'Department Name'
FROM Employees e
    INNER JOIN Departments d
    ON e.DepartmentID = d.DepartmentID
WHERE d.Name IN ('Sales', 'Finance')
AND YEAR(e.HireDate) BETWEEN 1995 AND 2005
``` 

Result: 
|Full Name|Department Name|
|---|
|Deborah Poe|Finance|
|Wendy Kahn|Finance|
|Candy Spoon|Finance|
|David Barber|Finance|
|Bryan Walton|Finance|


###### Resources:
 - [SQL (wikipedia)](https://en.wikipedia.org/wiki/SQL)
 - [Domain-specific Language (wikipedia)](https://en.wikipedia.org/wiki/Domain-specific_language)
 - [Transact-SQL](https://en.wikipedia.org/wiki/Transact-SQL)
