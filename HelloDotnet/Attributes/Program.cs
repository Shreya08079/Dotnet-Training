using System;
namespace HelloDotnet{


public class Calculator{
    [Obsolete("Use Add(int a, int b) method instead")]
    public int Sum(int a, int b){
        return a + b;
    }
    public int Add(int a, int b){
        return a + b;
    }
}

    public class Program{
        public static void Main(string[] args){
            Calculator calc = new Calculator();
            // This will generate a warning because Sum is obsolete
            int result1 = calc.Sum(3, 4);
            int result2 = calc.Add(5, 6);
            Console.WriteLine("Result from Sum: " + result1);
            Console.WriteLine("Result from Add: " + result2);
        }
    }
}
