// using System;
// using System.Threading.Tasks;

// class Program
// {
//     static async Task Main()
//     {
//         await SaveAsync();                // Task (no return)
//         int total = await GetTotalAsync(); // Task<int> (returns value)
//         Console.WriteLine(total);
//     }

//     static async Task SaveAsync()
//     {
//         await Task.Delay(3000); // pretend we saved to DB
//         Console.WriteLine("Saved!");
//     }

//     static async Task<int> GetTotalAsync()
//     {
//         await Task.Delay(3000); // pretend we calculated
//         return 42;
//     }
// }

using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HelloDotnet
{
    class Program
    {
        static async Task Main()
        {
            HttpClient client = new HttpClient();

            Console.WriteLine("Fetching data from google.com\n");
            string googleData = await client.GetStringAsync("https://www.google.com");
            Console.WriteLine("Google response");
            Console.WriteLine(googleData.Substring(0, 200));


            Console.WriteLine("Fetching todo api\n");
            string todoData = await client.GetStringAsync(
                "https://jsonplaceholder.typicode.com/todos/1"
            );
            Console.WriteLine("Todo API response:");
            Console.WriteLine(todoData);
        }
    }
}
