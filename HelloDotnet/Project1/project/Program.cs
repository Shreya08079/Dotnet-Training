// using System;
// using DataDesign;

// namespace ExamSchedulling
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("******** STUDENTS ********");
//             var students = DataBank.GetStudents();

//             foreach (var student in students)
//             {
//                 Console.WriteLine($"Id: {student.Id}, Name: {student.Name}");
//             }

//             Console.WriteLine("\n******** SESSIONS ********");
//             var sessions = DataBank.GetStudentSessions();

//             foreach (var item in sessions)
//             {
//                 Console.WriteLine(
//                     $"Session Id: {item.Session.Id}, " +
//                     $"Name: {item.Session.Name}, " +
//                     $"Detail: {item.Session.Detail}"
//                 );
//             }
//         }
//     }
// }
