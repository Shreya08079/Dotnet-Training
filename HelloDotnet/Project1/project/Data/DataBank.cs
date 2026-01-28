using ModelDesign;
using System.Collections.Generic;

namespace DataDesign
{
    public static class DataBank
    {
        private static List<Student> students = new();
        private static List<StudentSession> studentSessions = new();

        public static List<StudentsAndSession> studentsAndSessions = new();

        // Static constructor
        static DataBank()
        {
            students.Add(new Student { Id = 1, Name = "xoxo" });
            students.Add(new Student { Id = 2, Name = "yoyo" });

            studentSessions.Add(new StudentSession
            {
                Id = "S001",
                Name = "Dotnet",
                Detail = "Basics"
            });

            studentSessions.Add(new StudentSession
            {
                Id = "A001",
                Name = "Java",
                Detail = "Basics"
            });

            studentSessions.Add(new StudentSession
            {
                Id = "P001",
                Name = "Python",
                Detail = "Basics"
            });



            


        }

        public static List<Student> GetStudents()
        {
            return students;
        }

        public static List<StudentsAndSession> GetStudentSessions()
        {
            List<StudentsAndSession> result = new();

            foreach (var session in studentSessions)
            {
                result.Add(new StudentsAndSession
                {
                    Session = session,
                    SessionStudents = students 
                });
            }

            return result;
        }
    }
}
