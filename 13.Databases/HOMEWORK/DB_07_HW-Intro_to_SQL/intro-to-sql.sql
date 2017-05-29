USE TelerikAcademy

-- 04. Write a SQL query to find all information about all departments (use TelerikAcademy database)
SELECT * FROM Departments

-- 05. Write a SQL query to find all department names.
SELECT Name FROM Departments

-- 06. Write a SQL query to find the salary of each employee.
 SELECT FirstName + ' ' + LastName AS [Full Name],
 Salary FROM Employees

-- 07. Write a SQL to find the full name of each employee.
SELECT FirstName + ' ' + LastName AS [Full Name] FROM Employees

-- 08. Write a SQL query to find the email addresses of each employee (by his first and last name). Consider that the mail domain is telerik.com. Emails should look like “John.Doe@telerik.com". The produced column should be named "Full Email Addresses".
SELECT FirstName + '.' + LastName + '@telerik.com' AS [Full Email Address]
FROM Employees

-- 09. Write a SQL query to find all different employee salaries.
SELECT DISTINCT Salary
FROM Employees
ORDER BY Salary DESC

-- 10. Write a SQL query to find all information about the employees whose job title is “Sales Representative“.
SELECT *
FROM Employees
WHERE JobTitle = 'Sales Representative'

-- 11. Write a SQL query to find the names of all employees whose first name starts with "SA".
SELECT *
FROM Employees
WHERE FirstName LIKE 'SA%'

-- 12. Write a SQL query to find the names of all employees whose last name contains "ei".
SELECT *
FROM Employees
WHERE LastName LIKE '%ei%'

-- 13. Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].
SELECT FirstName, LastName, Salary
FROM Employees
WHERE Salary BETWEEN 20000 AND 30000

-- 14. Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.
SELECT FirstName + ' ' + LastName AS [Full Name],
	   Salary
FROM Employees
WHERE Salary in (25000, 14000, 12500, 23600)

-- 15. Write a SQL query to find all employees that do not have manager.
SELECT * FROM Employees
WHERE ManagerID IS NULL

-- 16. Write a SQL query to find all employees that have salary more than 50000. Order them in decreasing order by salary.
SELECT FirstName, LastName, Salary
FROM Employees
WHERE Salary > 50000
ORDER BY Salary DESC

-- 17. Write a SQL query to find the top 5 best paid employees.
SELECT TOP 5
FirstName, LastName, Salary
FROM Employees
ORDER BY Salary DESC

-- 18. Write a SQL query to find all employees along with their address. Use inner join with `ON` clause.
SELECT e.FirstName + ' ' + e.LastName AS [Full Name],
	   a.AddressText AS [Address]
FROM Employees e
	JOIN Addresses a
    ON e.AddressID = a.AddressID

-- 19. Write a SQL query to find all employees and their address. Use equijoins (conditions in the `WHERE` clause).
SELECT e.FirstName + '' + e.LastName AS [Full Name],
	   a.AddressText AS [Address]
FROM Employees e, Addresses a
WHERE e.AddressID = a.AddressID

-- 20. Write a SQL query to find all employees along with their manager.
SELECT e.FirstName + ' ' + e.LastName AS [Full Name],
       m.FirstName + ' ' + m.LastName AS [Manager Name]
FROM Employees e
	JOIN Employees m
    ON e.ManagerID = m.EmployeeID

-- 21. Write a SQL query to find all employees, along with their manager and their address. Join the 3 tables: `Employees e`, `Employees m` and `Addresses a`.
SELECT e.FirstName + ' ' + e.LastName AS [Full Name],
       m.FirstName + ' ' + m.LastName AS [Manager Name],
	   a.AddressText AS [Manager Address]
FROM Employees e
	JOIN Employees m
	ON e.ManagerID = m.EmployeeID
		JOIN Addresses a
		ON m.AddressID = a.AddressID

-- 22. Write a SQL query to find all departments and all town names as a single list. Use `UNION`.
SELECT Name FROM Departments
UNION
SELECT Name FROM Towns

-- 23. Write a SQL query to find all the employees and the manager for each of them along with the employees that do not have manager. Use right outer join. Rewrite the query to use left outer join.
SELECT m.FirstName + ' ' + m.LastName AS [Manager Name],
       e.FirstName + ' ' + e.LastName AS [Employee Name]
FROM Employees m
    RIGHT OUTER JOIN Employees e
    ON e.ManagerID = m.EmployeeID

-- Query rewritten with left outer join:
SELECT e.FirstName + ' ' + e.LastName AS [Employee Name],
       m.FirstName + ' ' + m.LastName AS [Manager name]
FROM Employees e
    LEFT OUTER JOIN Employees m
    ON e.ManagerID = m.EmployeeID

-- 24. Write a SQL query to find the names of all employees from the departments "Sales" and "Finance" whose hire year is between 1995 and 2005.
SELECT e.FirstName + ' ' + e.LastName AS [Full Name], 
       d.Name as [Department Name]
FROM Employees e
    INNER JOIN Departments d
    ON e.DepartmentID = d.DepartmentID
WHERE d.Name IN ('Sales', 'Finance')
AND YEAR(e.HireDate) BETWEEN 1995 AND 2005
