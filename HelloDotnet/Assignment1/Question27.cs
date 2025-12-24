using System;

namespace HelloDotnet.Assignment1
{
    class Question27
    {
        // This method prints numbers from 1 to 50 skipping multiples of 3
        public static void Run()
        {
            // Loop from 1 to 50
            for (int i = 1; i <= 50; i++)
            {
                // Skip numbers which are multiples of 3
                if (i % 3 == 0)
                {
                    continue;
                }

                // Print the number
                Console.WriteLine(i);
            }
        }
    }
}
