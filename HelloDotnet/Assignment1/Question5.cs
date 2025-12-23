using System;
namespace HelloDotnet.Assignment1
{
    class Question5
    {
        // This method checks whether a student is eligible for admission
        public static void Run()
        {
            // Variables to store marks 
            int math;
            int physics;
            int chemistry;

            //Taking marks from user
            Console.Write("Enter marks in Mathematics: ");
            math = int.Parse(Console.ReadLine()!);

            Console.Write("Enter marks in Physics: ");
            physics = int.Parse(Console.ReadLine()!);

            Console.Write("Enter marks in Chemistry: ");
            chemistry = int.Parse(Console.ReadLine()!);

            //Calculating total marks
            int total = math + physics + chemistry;
            int mathPhysicsTotal = math + physics;

            //Checking eligibility criteria
            if(math>=65 && physics >=55 && chemistry >=50 && (total >=180 || mathPhysicsTotal >=140))
            {
                Console.WriteLine("The student is eligible for admission.");
            }
            else{
                Console.WriteLine("The student is eligible for admission.");
            }
            
        }
    }
}