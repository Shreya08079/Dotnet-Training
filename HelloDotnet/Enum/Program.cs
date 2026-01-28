// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// namespace HelloDotnet{
// public enum WeekDays
// {
//     Sunday,
//     Monday,
//     Tuesday,
//     Wednesday,
//     Thursday,
//     Friday,
//     Saturday
// }

// public enum ProductCategory
// {
//     Electronics = 1,
//     Clothing = 2,
//     Groceries = 3,
// }
// public class Program
// {
//     public static void Main()
//     {
//         // WeekDays today = WeekDays.Wednesday;
//         // Console.WriteLine("Today is: " + today);

//         // ProductCategory category = ProductCategory.Electronics;
//         // Console.WriteLine("Selected Category: " + category + " with value " + (int)category);

//             int numValuePara = 0;
//             string variableForDay = GetWeekDay(WeekDays.Thursday, ref numValuePara);
//             Console.WriteLine(variableForDay);
//             Console.WriteLine(numValuePara);
//             Console.WriteLine(MenuByDay(WeekDays.Thursday));
//     }
//     public static string GetWeekDay(WeekDays weekDays, ref int  numValue)
//         {
//              numValue = (int)weekDays;
//             return weekDays.ToString();
//         }
//          public static string MenuByDay(WeekDays day)
//         {
//             switch(day)
//             {
//                 case WeekDays.Monday:
//                     return "Pasta";
//                 case WeekDays.Tuesday:
//                     return "Tacos";
//                 case WeekDays.Wednesday:
//                     return "Chicken Curry";
//                 case WeekDays.Thursday:
//                     return "Pizza";
//                 case WeekDays.Friday:
//                     return "Fish and Chips";
//                 case WeekDays.Saturday:
//                     return "Burgers";
//                 case WeekDays.Sunday:
//                     return "Roast Dinner";
//                 default:
//                     return "Unknown Day";
//             }
//         }
// }
// }

