using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
    public string ?EmployeeId { get; set; }
    public string ?Name { get; set; }
    public string ?Department { get; set; }
    public double Salary { get; set; }
    public DateTime JoiningDate { get; set; }
}


public class HRManager
{
    private List<Employee> employees = new List<Employee>();
    private int employeeCounter = 0;

    public void AddEmployee(string name, string dept, double salary)
    {
        employeeCounter++;

        Employee emp = new Employee
        {
            EmployeeId = $"E{employeeCounter:D3}",
            Name = name,
            Department = dept,
            Salary = salary,
            JoiningDate = DateTime.Now
        };

        employees.Add(emp);
    }

    public SortedDictionary<string, List<Employee>> GroupEmployeesByDepartment()
    {
        var grouped = new SortedDictionary<string, List<Employee>>();

        foreach (var emp in employees)
        {
            if (!grouped.ContainsKey(emp.Department))
            {
                grouped[emp.Department] = new List<Employee>();
            }

            grouped[emp.Department].Add(emp);
        }

        return grouped;
    }

    public double CalculateDepartmentSalary(string department)
    {
        return employees
            .Where(e => e.Department.Equals(department, StringComparison.OrdinalIgnoreCase))
            .Sum(e => e.Salary);
    }

    public List<Employee> GetEmployeesJoinedAfter(DateTime date)
    {
        return employees
            .Where(e => e.JoiningDate > date)
            .ToList();
    }
}
class Program
{
    static void Main()
    {
        HRManager hr = new HRManager();

        // 1. Add employees
        hr.AddEmployee("Alice", "HR", 40000);
        hr.AddEmployee("Bob", "IT", 60000);
        hr.AddEmployee("Charlie", "Sales", 50000);
        hr.AddEmployee("David", "IT", 65000);

        // 2. Display department-wise employees
        Console.WriteLine("Employees grouped by department:\n");

        var grouped = hr.GroupEmployeesByDepartment();
        foreach (var dept in grouped)
        {
            Console.WriteLine($"Department: {dept.Key}");
            foreach (var emp in dept.Value)
            {
                Console.WriteLine($"  {emp.EmployeeId} - {emp.Name} - {emp.Salary}");
            }
            Console.WriteLine();
        }

        // 3. Calculate total salary per department
        Console.WriteLine("Total IT Department Salary:");
        Console.WriteLine(hr.CalculateDepartmentSalary("IT"));

        // 4. Find recently joined employees
        Console.WriteLine("\nEmployees joined after today morning:");
        DateTime todayMorning = DateTime.Today;

        var recentEmployees = hr.GetEmployeesJoinedAfter(todayMorning);
        foreach (var emp in recentEmployees)
        {
            Console.WriteLine($"{emp.EmployeeId} - {emp.Name} ({emp.Department})");
        }
    }
}