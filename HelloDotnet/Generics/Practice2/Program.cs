// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter a number: ");
//         int number = int.Parse(Console.ReadLine());

//         // Predicate to check if number is even
//         Predicate<int> isEven = n => n % 2 == 0;

//         // Check the number and print result
//         if (isEven(number))
//         {
//             Console.WriteLine($"{number} is even");
//         }
//         else
//         {
//             Console.WriteLine($"{number} is odd");
//         }
//     }
// }

using System;
using System.Collections.Generic;
namespace HelloDotNet{
    public class Bike{
        public string Model{get; set;}
        public string Brand{get; set;}
        public int PricePerDay{get; set;}
    }

    public class BikeUtility{
        public void AddBikeDetails(string model, string brand, int pricePerDay){
            Bike bike = new Bike{
                Model = model,
                Brand=brand,
                PricePerDay=pricePerDay
            };

            Program.bikeDetails.Add(Program.bikeDetails.Count+1,bike);
            Console.WriteLine("Bike details added successfully!");
        }

        public SortedDictionary<string,List<Bike>>GroupBikesByBrand(){
            SortedDictionary<string,List<Bike>> groupedBikes = new SortedDictionary<string,List<Bike>>();

            foreach(var kvp in Program.bikeDetails){
                Bike bike = kvp.Value;
                if(!groupedBikes.ContainsKey(brand)){
                    groupedBikes[bike.brand] = new List<Bike>();
                }
                groupedBikes[bike.brand].Add(bike);
            }

            return groupedBikes;
        }
    }

    public class Program{
        
    }
}