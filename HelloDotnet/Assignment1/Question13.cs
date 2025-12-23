using System;

namespace HelloDotnet.Assignment1
{
    class Question13
    {
        // This method calculates profit or loss percentage
        public static void Run()
        {
            // Variables to store cost price and selling price
            double costPrice;
            double sellingPrice;

            // Taking cost price from user
            Console.Write("Enter Cost Price: ");
            costPrice = double.Parse(Console.ReadLine()!);

            // Taking selling price from user
            Console.Write("Enter Selling Price: ");
            sellingPrice = double.Parse(Console.ReadLine()!);

            // Checking profit or loss
            if (sellingPrice > costPrice)
            {
                double profit = sellingPrice - costPrice;
                double profitPercent = (profit / costPrice) * 100;
                Console.WriteLine("Profit Percentage: " + profitPercent);
            }
            else if (sellingPrice < costPrice)
            {
                double loss = costPrice - sellingPrice;
                double lossPercent = (loss / costPrice) * 100;
                Console.WriteLine("Loss Percentage: " + lossPercent);
            }
            else
            {
                Console.WriteLine("Neither profit, nor loss");
            }
        }
    }
}
