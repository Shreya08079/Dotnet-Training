using System;

namespace HelloDotnet
{
    // Base Class
    class Cab
    {
        public virtual double CalculateFare(int km)
        {
            return 0;
        }
    }

    class Mini : Cab
    {
        public override double CalculateFare(int km)
        {
            return km * 12;
        }
    }

    class Sedan : Cab
    {
        public override double CalculateFare(int km)
        {
            return km * 15 + 50;
        }
    }

    class SUV : Cab
    {
        public override double CalculateFare(int km)
        {
            return km * 18 + 100;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter cab type (Mini / Sedan / SUV):");
            string cabType = Console.ReadLine()!;

            Console.WriteLine("Enter distance in km:");
            int km = Convert.ToInt32(Console.ReadLine());

            Cab cab; // base class reference

            if (cabType == "Mini")
                cab = new Mini();
            else if (cabType == "Sedan")
                cab = new Sedan();
            else
                cab = new SUV();

            double fare = cab.CalculateFare(km);
            Console.WriteLine("Total Fare = " + fare);
        }
    }
}
