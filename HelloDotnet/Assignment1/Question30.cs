using System;

namespace HelloDotnet.Assignment1
{
    class Question30
    {
        // This method search using goto to exit nested loops
        public static void Run()
        {
            int target = 7;
            bool found = false;

            // Nested loops for searching
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.WriteLine("Checking value: " + (i + j));

                    // Condition to check target
                    if (i + j == target)
                    {
                        found = true;
                        goto Found;   // Exit all loops immediately
                    }
                }
            }

        Found:
            // After exiting loops using goto
            if (found)
            {
                Console.WriteLine("Target value found");
            }
            else
            {
                Console.WriteLine("Target value not found");
            }
        }
    }
}
