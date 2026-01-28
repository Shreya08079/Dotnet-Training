using System;

namespace HelloDotnet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int? ans = Divide(10, 0);
        }

        public static int? Divide(int a, int b)
        {
            try
            {
                if (b == 0)
                {
                    throw new AppCustomException();
                }

                return a / b;
            }
            catch (AppCustomException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return null;
        }
    }
}

