using System;

namespace HelloDotnet
{
    public partial class Csharp
    {
        public static void Run()
        {
            Csharp s = new Csharp
            {
                RollNo = 1,
                Name = "Shreya"
            };

            Console.WriteLine($"Roll No: {s.RollNo}");
            Console.WriteLine($"Name: {s.Name}");
        }
    }
}
