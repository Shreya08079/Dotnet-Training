using System;

public class BonusCalculator
{
    public static void Main(string[] args)
    {
        int[] salaries = { 5000, 0, 7000, 0};
        int bonus = 10000;

        for (int i = 0; i < salaries.Length; i++)
        {
            try
            {
                int result = bonus / salaries[i];
                Console.WriteLine($"Employee {i + 1} bonus share: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Employee {i + 1}: Salary is zero, cannot calculate bonus.");
            }
        }

        Console.WriteLine("Bonus Calculation is done for all the employees.");
    }
}
