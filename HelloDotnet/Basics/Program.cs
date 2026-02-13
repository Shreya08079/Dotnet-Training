using System;
namespace HelloDotnet{

public class Program
{
    public static void Main()
    {

        //question 1
        string input = "42";
        int number = int.Parse(input);

        Console.WriteLine("Integer value: " + number);
        //question 2
        string input = "12.34";
        double number = double.Parse(input);

        Console.WriteLine("Double value: " + number);

        //question 3
        string input = " 1 2 3 4";

        string[] parts = input.Split(' ');
        int[] numbers = new int[parts.Length];

        for(int i = 0; i< parts.Length; i++)
        {
            numbers[i] = int.Parse(parts[i]);
        }
        foreach(int num in numbers)
        {
            Console.WriteLine(num);
        }
    
        //question 4
        string input = "9.5 8.3 7.1";
        string[] parts = input.Split(' ');
        double[] numbers = new double[parts.Length];

            for(int j = 0; j <parts.Length; j++){
                numbers[j] =double.Parse(parts[j]);

            }
            foreach(double num in numbers)
            {
                Console.WriteLine(num);
            }
//Question 5
    string input = "fifty";
        if(int.TryParse(input , out int number))
        {
            Console.WriteLine("Valid Number"+ number);
        }
        else
        {
            Console.WriteLine("Not a number at all.");
        }
//Question 6
string input = "15.7abc";
string result = "";
bool decimalFound = false;

foreach(char c in input)
        {
            if (char.IsDigit(c))
            {
                result += c;
            }
            else if(c == '.' && !decimalFound)
            {
                result += c;
                decimalFound = true;
            }
        }
        Console.WriteLine("Numeric portion: "+ result);

//Question 7
string input1 = "99999999";
long number = long.Parse(input1);

Console.WriteLine("Long Value: "+ number);

//Question 8 -- Hex format

string input2 = "0xFF";

string hexValue = input2.Substring(2);

int num = Convert.ToInt32(hexValue, 16);

Console.WriteLine("Decimal Value: "+ num);

//Question 9
    string input = "3E+3";

    double number = double.Parse(input);

    Console.WriteLine("Double value: " + number);

//Question 10
    string input = "42.5 36.1 -12";

        string[] parts = input.Split(' ');

        foreach (string part in parts)
        {
            if (double.TryParse(part, out double number))
            {
                Console.WriteLine("Valid number: " + number);
            }
            else
            {
                Console.WriteLine("Invalid value: " + part);
            }
        }
//Question 11
string input = " 75 ";

        string trimmed = input.Trim();

        if (int.TryParse(trimmed, out int number))
        {
            Console.WriteLine("Integer value: " + number);
        }
        else
        {
            Console.WriteLine("Invalid number");
        }

//Question 12
    string input = "3.14.15";

        if (double.TryParse(input, out double result))
        {
            Console.WriteLine("Valid number: " + result);
        }
        else
        {
            Console.WriteLine("Invalid number format.");
        }
//Question 13
string input = "1.000.000";

        // Remove dot separators
        string cleaned = input.Replace(".", "");

        if (int.TryParse(cleaned, out int result))
        {
            Console.WriteLine("Parsed number: " + result);
        }
        else
        {
            Console.WriteLine("Invalid number format.");
        }

        // question 14 
        string q14 = "1,234.56";
        double a14 = double.Parse(q14.Replace(",", ""));
        Console.WriteLine("Comma formatted double : " + a14);


        // question 15 
        string q15 = "(123)";
        int a15 = -int.Parse(q15.Trim('(', ')'));
        Console.WriteLine("Negative number : " + a15);


        // question 16 
        string q16 = "12:30";
        string[] time = q16.Split(':');

        int totalMinutes = int.Parse(time[0]) * 60 + int.Parse(time[1]);
        Console.WriteLine("Total minutes : " + totalMinutes);


        // question 17 
        string q17 = "$1,500.75";
        string clean17 = q17.Replace("$", "").Replace(",", "");
        double a17 = double.Parse(clean17);
        Console.WriteLine("Currency value : " + a17);


        // question 18 
        string q18 = "8 16 32 bits";
        var nums18 = Regex.Matches(q18, @"\d+");

        int sum18 = 0;
        foreach (Match m in nums18)
            sum18 += int.Parse(m.Value);

        Console.WriteLine("Sum : " + sum18);


        // question 19 
        string q19 = "0b1011";
        int a19 = Convert.ToInt32(q19.Replace("0b", ""), 2);
        Console.WriteLine("Binary to int : " + a19);


        // question 20 
        string q20 = "2,000 apples and 3,500 oranges";

        var nums20 = Regex.Matches(q20, @"[\d,]+");

        int sum20 = 0;
        foreach (Match m in nums20)
        {
            string clean = m.Value.Replace(",", "");
            sum20 += int.Parse(clean);
        }

        Console.WriteLine("Total fruits : " + sum20);


}
}
}