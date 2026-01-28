// using System;
// namespace HelloDotnet
// {
    
//     public delegate string PrintMessage(string message);

//     public class PrintingCompany
//     {
//         public PrintMessage CustomerChoicePrintMessage{ get; set; }

//         public void Print(string message)
//         {
//             string messageToPrint = CustomerChoicePrintMessage(message);
//             Console.WriteLine(messageToPrint);
//         }
//     }

//     public class PrintingCompanyMain
//     {
//         public static void Main(string[] args)
//         {
//             PrintingCompany print = new PrintingCompany();
//             print.CustomerChoicePrintMessage = new PrintMessage(HappyDiwali);
//             print.Print("Wishing you a joyous Diwali!");
//             Console.ReadLine();
//         }
//         private static string method(string message)
//         {
//             return "Welcome to Delegate World-----"+ message;
//         }
//         private static string HappyNewYear(string message)
//         {
//             return "Happy New Year! " + message;
//         }

//         private static string HappyDiwali(string message)
//         {
//             return "Happy Diwali! " + message;
//         }
//     }
// }


int asciiSum = 0;
        for (int i = 0; i < 4; i++)
        {
            char lower = char.ToLower(username[i]);
            asciiSum += lower;
        }

        int lastTwoDigits = courseId % 100;

        Console.WriteLine("Password: TECH_" + asciiSum + lastTwoDigits);