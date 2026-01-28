using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;



// class LinqStudent
//     {
//         public string Name { get; set; }
//         //public string Result { get; set; }
//     }   
// class MyProcess
// {
//     public string Name { get; set; }
//     public int Id { get; set; }
// }

// class Program
// {

//     private static void LinqExample2()
//     {
//         var proCollection =
//             from p in Process.GetProcesses()
//             select new MyProcess
//             {
//                 Name = p.ProcessName,
//                 Id = p.Id
//             };

//         foreach (var proc in proCollection) 
//         {
//             Console.WriteLine($"Process Name = {proc.Name}, Id = {proc.Id}");
//         }
//     }
//     public static void Main(string[] args)
//     {
//         string[] names = { "A", "B", "C" , "Madam", "xoxo"};

//         var findName = from name in names
//                        //where name == "B"
//                        orderby name descending
//                        //select name.ToLower();
//                        //select IsPalindrome(name);
//                        select new LinqStudent(){ Name = name };

//         foreach (var n in findName)
//             Console.WriteLine(n);

//         Console.WriteLine("\nProcesses:");
//         LinqExample2();
//     }

//         // if (findName.Any())
//         //     Console.WriteLine("Found name B");
//         // else
//         //     Console.WriteLine("B not found");
//     // }

//     public static string IsPalindrome(string name){
//     string reversed = new string(name.ToLower().Reverse().ToArray());

//     if (reversed == name.ToLower())
//         return "Palindrome " + name;
//     else
//         return "Not a Palindrome " + name;
//     }

    

// }

class Student{
    public int RollNo {get; set;}
    public string Name{ get; set;}
    public int Mark1{get; set;}
    public int Mark2 {get; set;}
}
class Program{
    public static void Main(){
        List<Student> students = new List<Student>
        {
            new Student { RollNo = 1, Name = "Alice", Mark1 = 85, Mark2 = 90 },
            new Student { RollNo = 2, Name ="Shreya", Mark1 = 67, Mark2= 80},
            new Student { RollNo = 3, Name ="Aaruhi", Mark1 = 68, Mark2= 100}
        };

        // var marks = students.Select (s=> new
        // {
        //     s.Name,
        //     s.RollNo,
        //     MaxMark = Math.Max(s.Mark1, s.Mark2)
        // });

        //  Console.WriteLine("Maximum Marks ");
        // foreach (var student in marks)
        // {
        //     Console.WriteLine($"Roll No: {student.RollNo}, Name: {student.Name}, Max Mark: {student.MaxMark}");
        // }

        double classAverage = students.Average(s => (s.Mark1 + s.Mark2) / 2.0);
        Console.WriteLine("Class Average: " + classAverage);
        var studentWithAverage = from stu in students 
                                select new { Id=stu.RollNo, Name = stu.Name, Average = (stu.Mark1 + stu.Mark2)/2};

        Console.WriteLine("\nStudent Averages:");
            foreach (var s in studentWithAverage)
            {
                Console.WriteLine(
                $"Roll No: {s.Id}, Name: {s.Name}, Average: {s.Average}"
            );
        
            }
    }
}

