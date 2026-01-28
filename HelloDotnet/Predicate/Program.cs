using System;
namespace HelloDotnet{
    public class Program{
        static void Main(string[] args){
            Predicate<int> isEven = number => number % 2 ==0;
            bool check = isEven(10);
            Console.WriteLine(check);


            Action<string> logger = message =>{
                Console.WriteLine($"[LOG] {message} at {DateTime.Now}");
            };
            logger("Application Started");

            Func<int, int, string> multiplyResult = (x,y) =>{
                return $"{x} times {y} is { x * y}";
            };

            string resultText = multiplyResult(5,4);
            Console.WriteLine(resultText);
        }
    }
}