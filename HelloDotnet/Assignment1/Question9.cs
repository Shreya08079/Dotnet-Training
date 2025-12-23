using System;
namespace HelloDotnet.Assignment1
{
    class Question9
    {
        // This method finds the quadrant of a point based on x and y coordinates
        public static void Run()
        {
            // Declare variables for x and y coordinates
            int x;
            int y;

            //Taking input from users for coordinate values 

            Console.WriteLine("Enter the value of x coordinate : ");
            x = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the value of y coordinate: ");
            y = int.Parse(Console.ReadLine()!);

            //Determining the quadrant based on the values of x and y coordinates

            if(x>0 && y > 0)
            {
                Console.WriteLine("The point lies in first quadrant.");
            }
            else if(x<0 && y> 0){
                Console.WriteLine("The point lies in second quadrant.");
            }
            else if(x<0 && y < 0)
            {
                Console.WriteLine("The point lies in the third quadrant.");
            }
            else if(x>0 && y < 0){
                Console.WriteLine("The point lies in the fourth Quadrant.");
            }
            else if(x==0 && y == 0)
            {
                Console.WriteLine("The point lies at the origin.");
            }
            else
            {
                Console.WriteLine("The point lies on one of the axes.");
            }

        }
    }
}