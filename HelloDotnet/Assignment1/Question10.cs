using System;
namespace Hellodotnet.assignment1
{
    class Question10{
    // This method prints grade description based on grade input
    public static void Run()
    {
        //Taking input grade from user
        char grade;
        Console.WriteLine("Enter grade(E,V,G,A,F) :");
        grade = char.Parse(Console.ReadLine()!);

            //using switch case to print the description of each grade
            switch (grade)
            {
                case 'E':
                case 'e':
                    Console.WriteLine("Excellent.");
                break;

                case 'V':
                case 'v':
                    Console.WriteLine("Very Good.");
                break;

                case 'G':
                case 'g':
                    Console.WriteLine("Good.");
                break;

                case 'A':
                case 'a':
                    Console.WriteLine("Average.");
                break;

                case 'F':
                case 'f':
                    Console.WriteLine("Fail.");
                break;

                default:
                    Console.WriteLine("Invalid grade entered .Please enter valid grade.");
                break;
                    
            }

    }
}
}