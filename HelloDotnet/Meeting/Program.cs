using System;
using System.Collections.Generic;

public class Student
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? Course { get; set; }
    public int Marks { get; set; }
}

public class StudentUtility
{
    public Dictionary<string, string> GetStudentDetails(string id)
    {
        Dictionary<string, string> result = new Dictionary<string, string>();

        foreach (var item in Program.studentDetails.Values)
        {
            if (item.Id == id)
            {
                result.Add(item.Id!, item.Name + "-" + item.Course);
                break;
            }
        }
        return result;
    }

    public Dictionary<string, Student> UpdateStudentMarks(string id, int marks)
    {
        Dictionary<string, Student> result = new Dictionary<string, Student>();

        foreach (var item in Program.studentDetails.Values)
        {
            if (item.Id == id)
            {
                item.Marks = marks;
                result.Add(item.Id!, item);
                break;
            }
        }
        return result;
    }
}

public class Program
{
    public static Dictionary<int, Student> studentDetails;

    public static void Main(string[] args)
    {
        studentDetails = new Dictionary<int, Student>();

        studentDetails.Add(1, new Student { Id = "S101", Name = "Alice", Course = "Math", Marks = 85 });
        studentDetails.Add(2, new Student { Id = "S102", Name = "Bob", Course = "Science", Marks = 90 });

        StudentUtility utility = new StudentUtility();

        while (true)
        {
            Console.WriteLine("1. Get Student Details");
            Console.WriteLine("2. Update Marks");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine()!);

            if (choice == 1)
            {
                Console.Write("Enter the student id: ");
                string id = Console.ReadLine()!;

                var result = utility.GetStudentDetails(id);

                if (result.Count == 0)
                    Console.WriteLine("Student id not found");
                else
                    foreach (var item in result)
                        Console.WriteLine(item.Key + " " + item.Value);
            }
            else if (choice == 2)
            {
                Console.Write("Enter the student id: ");
                string id = Console.ReadLine()!;

                Console.Write("Enter the new marks: ");
                int marks = int.Parse(Console.ReadLine()!);

                var result = utility.UpdateStudentMarks(id, marks);

                if (result.Count == 0)
                    Console.WriteLine("Student id not found");
                else
                    foreach (var item in result)
                        Console.WriteLine(item.Key + " " +item.Value.Marks);
            }
            else if (choice == 3)
            {
                Console.WriteLine("Thank you");
                break;
            }
        }
    }
}
