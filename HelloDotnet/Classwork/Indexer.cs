using System;

namespace HelloDotnet
{
    // Student class with Indexer
    public class Student
    {
        private string[] names = new string[3];

        // Indexer
        public string this[int index]
        {
            get
            {
                return names[index];
            }
            set
            {
                names[index] = value;
            }
        }
    }

    
    public class Indexers
    {
        public static void Run()
        {
            Student s = new Student();

            s[0] = "Shreya";
            s[1] = "xoxo";
            s[2] = "yoyo";

            Console.WriteLine(s[0]);
            Console.WriteLine(s[1]);
            Console.WriteLine(s[2]);
        }
    }
}
