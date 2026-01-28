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
using System;

namespace HelloDotnet
{
    public delegate string MyDelegate(string message);

    public class PrintingCompany
    {
        public MyDelegate? MultiCastPrintMessage { get; set; }

        public void Print(string message)
        {
            if (MultiCastPrintMessage == null)
                return;

            foreach (MyDelegate handler in MultiCastPrintMessage.GetInvocationList())
            {
                string result = handler(message);
                Console.WriteLine(result);
            }
        }
    }

    public class MultiCastDelegate
    {
        public static void Main()
        {
            MyDelegate d = Method1;
            d += Method2;
            d += Method3;

            // This calls all three methods
            d("Hello");

            Console.ReadLine();
        }

        private static string Method1(string message)
        {
            Console.WriteLine("A: " + message);
            return "A: " + message;
        }

        private static string Method2(string message)
        {
            Console.WriteLine("B: " + message);
            return "B: " + message;
        }

        private static string Method3(string message)
        {
            Console.WriteLine("C: " + message);
            return "C: " + message;
        }
    }
}