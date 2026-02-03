// public class Student
// {
//     public string? name {get; set;}
//     public int mark1 {get; set;}
//     public int mark2 {get; set;}

// }
// public delegate void Notification(string message);

// public class Program
// {
//     public static double avgMarks(int marks1 , int marks2){
//             return (marks1+marks2)/2.0;
//     }

//      public static void notification(string message)
//     {
//         Console.WriteLine(message);
//     }
//     public static void Main(string[] args)
//     {
//         Student s1 = new Student()
//         {
//             name = "Shreya",
//             mark1 = 80,
//             mark2=90
//         };
//         Student s2 = new Student()
//         {
//             name = "Aaruhi",
//             mark1 = 70,
//             mark2=75
//         };
//         Student s3 = new Student()
//         {
            
//             mark1 = 32,
//             mark2=23
//         };

//         List<Student> students = new List<Student>();
//         students.Add(s1);
//         students.Add(s2);
//         students.Add(s3);

//         Notification notify = notification;
//         // Console.WriteLine($"avg of the marks of student 1 :{avgMarks(s1.mark1,s1.mark2):F2}");
//         // Console.WriteLine($"avg of the marks of student 2 :{avgMarks(s2.mark1,s2.mark2):F2}");

//         for(int idx = 0; idx<students.Count;idx++){
//             double avg = avgMarks(students[idx].mark1, students[idx].mark2);
//             Console.WriteLine($"avg of the marks of student {idx + 1} : {avg:F2}");

//             if (avg < 40)
//             {
//                notify($"Improvement required for student {idx + 1} as its avg is {avg:F2}");
//             }
//         }
//     }

// }

// using System;
// using System.Collections.Generic;
// using System.Linq;

// public class Student
// {
//     public string? name { get; set; }
//     public int mark1 { get; set; }
//     public int mark2 { get; set; }
//     public double avg { get; set; }  
//     public int rank { get; set; }  
// }

// public delegate void Notification(string message);

// public class Program
// {
//     public static double avgMarks(int marks1, int marks2)
//     {
//         return (marks1 + marks2) / 2.0;
//     }

//     public static void notification(string message)
//     {
//         Console.WriteLine(message);
//     }

//     public static void Main(string[] args)
//     {
//         Student s1 = new Student() { name = "Shreya", mark1 = 80, mark2 = 90 };
//         Student s2 = new Student() { name = "Aaruhi", mark1 = 70, mark2 = 75 };
//         Student s3 = new Student() { name = "Ayush", mark1 = 32, mark2 = 23 };

//         List<Student> students = new List<Student> { s1, s2, s3 };

//         Notification notify = notification;

       
//         foreach (var student in students)
//         {
//             student.avg = avgMarks(student.mark1, student.mark2);
//             Console.WriteLine($"Avg marks of {student.name}: {student.avg:F2}");

//             if (student.avg < 40)
//                 notify($"Improvement required for {student.name} as avg is {student.avg:F2}");
//         }

      
//         var rankedStudents = students.OrderByDescending(s => s.avg).ToList();
//         for (int i = 0; i < rankedStudents.Count; i++)
//         {
//             rankedStudents[i].rank = i + 1;
//         }

        
//         Console.WriteLine("\n--- Student Rankings ---");
//         foreach (var student in rankedStudents)
//         {
//             Console.WriteLine($"Rank {student.rank}: {student.name} with avg {student.avg:F2}");
//         }
//     }
// }

using System;
namespace HelloDotNet
{
    public delegate void Notify();
    public class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public int Marks { get; set; }

        public int CompareTo(Student? other)
        {
            return other.Marks.CompareTo(this.Marks);
        }

        public event Notify OnNotify;

        public void NeedImpovement()
        {
            Console.WriteLine("Need Impovement");
        }

        public void GoodStudent()
        {
            Console.WriteLine("Good Student");
        }

        public void AverageStudent()
        {
            Console.WriteLine("Average Student");
        }

        public void SendNotification(Student s)
        {
            OnNotify = null;

            if (s.Marks <= 500)
            {
                OnNotify = NeedImpovement;
            }
            else if (s.Marks >= 560)
            {
                OnNotify = GoodStudent;
            }
            else
            {
                OnNotify = AverageStudent;
            }
            OnNotify?.Invoke();
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            List<Student> students = new List<Student>();
            students.Add(new Student
            {
                Name = "Vishwajeet",
                Marks = 500
            });
            students.Add(new Student
            {
                Name = "Thiluck",
                Marks = 450
            });
            students.Add(new Student
            {
                Name = "Pratham",
                Marks = 550
            });
            students.Add(new Student
            {
                Name = "Harsha",
                Marks = 600
            });
            students.Add(new Student
            {
                Name = "Annu",
                Marks = 560
            });
            students.Sort();
            int rank = 1;
            foreach(Student student in students)
            {
                Console.Write($"Rank = {rank++} Name = {student.Name}, Marks = {student.Marks}, Remarks: ");
                s.SendNotification(student);
                Console.WriteLine();
            }
        }
    }
}