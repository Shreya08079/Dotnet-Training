using System;
using System.Collections.Generic;

namespace HelloDotnet
{
    public class Hello
    {
        public int RollNo { get; set; }
        public string? Name { get; set; }

        private List<string> books = new List<string>();

        // Indexer (unlimited)
        public string this[int index]
        {
            get
            {
                return books[index];
            }
            set
            {
                if (index < books.Count)
                    books[index] = value;
                else
                    books.Add(value);
            }
        }
    }

    public class Indexerss
    {
        public static void Run()
        {
            Hello s = new Hello
            {
                RollNo = 101,
                Name = "Shreya"
            };

            s[0] = "C#";
            s[1] = "JAVA";
            s[2] = "CPP";
            s[3] = "Python";

            Console.WriteLine($"Roll No: {s.RollNo}");
            Console.WriteLine($"Name: {s.Name}");
            Console.WriteLine("Books:");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Book {i + 1}: {s[i]}");
            }
        }
    }
}
