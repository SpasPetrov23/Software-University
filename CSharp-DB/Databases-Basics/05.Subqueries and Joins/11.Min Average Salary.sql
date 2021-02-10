SELECT TOP(1) AVG(e.Salary) AS AverageSalary
FROM Employees AS e
JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
GROUP BY e.DepartmentID
ORDER BY AverageSalary