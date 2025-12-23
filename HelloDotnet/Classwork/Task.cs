// using System;

// namespace HelloDontnet.Classwork
// {
    // class Employee
    // {
    //     public int id;
    //     public string domain;
    //     public string name;

    //     public Employee(int id, string name, string domain)
    //     {
    //         this.id = id;
    //         this.name = name;
    //         this.domain = domain;
    //     }

    //     public void GetData()
    //     {
    //         Console.WriteLine($"Id: {id} Name: {name} Domain: {domain}");
    //     }
    // }

    // class Competition
    // {
    //     public string competitionName;
    //     public string level;
    //     public int Rank;

    //     public Competition(string competitionName, string level)
    //     {
    //         this.competitionName = competitionName;
    //         this.level = level;
    //     }

    //     public void GetCompetitionInfo()
    //     {
    //         Console.WriteLine($"Competition Name: {competitionName} Level: {level}");
    //     }
    // }

    // class CompetitionResult
    // {
    //     public Employee employee;
    //     public Competition competition;
    //     public int score;
    //     public string result;

    //     public CompetitionResult(Employee employee, Competition competition, int score)
    //     {
    //         this.employee = employee;
    //         this.competition = competition;
    //         this.score = score;
    //         this.result = score >= 50 ? "Pass" : "Fail";
    //     }

    //     public void DisplayResult()
    //     {
    //         employee.GetData();
    //         competition.GetCompetitionInfo();
    //         Console.WriteLine($"Score: {score} Result: {result}");
    //     }
    // }

    // class TaskRunner
    // {
    //     public static void Run()
    //     {
    //         Employee emp = new Employee(101, "Pinky", "Engineering");
    //         Competition comp = new Competition("Code Challenge", "National");
    //         CompetitionResult result = new CompetitionResult(emp, comp, 75);
    //         result.DisplayResult();
    //     }
    // }

using System;

namespace HelloDontnet.Classwork
{
    // Student class
    class Student
    {
        public string Name;
        public int Age;
        public int RollNo;
        public string Level;
        public string Course;

        public void Display()
        {
            Console.WriteLine(" Student Details");
            Console.WriteLine("Name       : " + Name);
            Console.WriteLine("Age        : " + Age);
            Console.WriteLine("Roll No    : " + RollNo);
            Console.WriteLine("Level      : " + Level);
            Console.WriteLine("Course     : " + Course);
            Console.WriteLine();
        }
    }

    class StudentRunner
    {
        public static void Run()
        {
            Console.Write("Enter number of students: ");
            int count = int.Parse(Console.ReadLine()!);

            
            Student[] students = new Student[count];

            for (int i = 0; i < count; i++)
            {
                Student s = new Student();

                Console.WriteLine("\nEnter details for student " + (i + 1));

                Console.Write("Name: ");
                s.Name = Console.ReadLine()!;

                Console.Write("Age: ");
                s.Age = int.Parse(Console.ReadLine()!);

                Console.Write("Roll Number: ");
                s.RollNo = int.Parse(Console.ReadLine()!);

                Console.WriteLine("Select Student Level:");
                Console.WriteLine("1. High School");
                Console.WriteLine("2. UG");
                Console.WriteLine("3. PG");
                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine()!);

                if (choice == 1)
                    s.Level = "High School";
                else if (choice == 2)
                    s.Level = "UG";
                else if (choice == 3)
                    s.Level = "PG";
                else
                    s.Level = "Unknown";

                Console.Write("Class / Degree / Specialization: ");
                s.Course = Console.ReadLine()!;

               
                students[i] = s;
            }

            Console.WriteLine("\n===== ALL STUDENT RECORDS =====");
            foreach (Student st in students)
            {
                st.Display();
            }
        }
    }
}
