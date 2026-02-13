using System;

namespace HelloDotnet
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, string email, double salary)
        {
            Id = id;
            Name = name;

            if (email.Contains("@"))
                Email = email;
            else
                Email = "unknown@company.com";

            if (salary > 0)
                Salary = salary;
            else
                Salary = 30000;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Email: {Email}, Salary: {Salary}");
        }
    }

    class Program
    {
        static void Main()
        {
            Employee emp1 = new Employee(1, "Shreya", "shreya@gmail.com", 50000);
            Employee emp2 = new Employee(2, "Aaruhi", "aaruhi@gmail.com", 60000);
            Employee emp3 = new Employee(3, "Alex", "alexgmail.com", 0);

            emp1.PrintDetails();
            emp2.PrintDetails();
            emp3.PrintDetails();
        }
    }
}
