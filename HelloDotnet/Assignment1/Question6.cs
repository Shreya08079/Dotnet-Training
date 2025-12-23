using System;

namespace HelloDotnet.Assignment1
{
    class Question6
    {
        // This method calculates electricity bill based on units consumed
        public static void Run()
        {
            int units;
            double billAmount = 0;
             //Taking units as input from user

             Console.Write("Enter the number of units consumed: ");
             units = int.Parse(Console.ReadLine()!);

             //Calculating bill amount based on units consumed
             if(units <= 199)
            {
                billAmount = units * 1.20;
            }
            else if(units >= 200 && units < 400)
            {
                billAmount = units * 1.50;
            }
            else if(units >=400 && units < 500)
            {
                billAmount = units * 1.80;
            }
            else
            {
                billAmount = units * 2.00;
            }

            //Adding surcharge if billAmount is greater than 400

            if(billAmount > 400)
            {
                billAmount = billAmount + (billAmount * 0.15);
            }
            else
            {
            //Displaying final bill amount 
            Console.WriteLine("The total electricity bill is : " + billAmount);
            }
        }
    }
}