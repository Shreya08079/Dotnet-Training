// using System;

// class ResourceHandler : IDisposable
// {
//     public ResourceHandler()
//     {
//         Console.WriteLine("Resource acquired.");
//     }

//     public void Dispose()
//     {
//         Console.WriteLine("Resource released.");
//     }
// }

// // Usage
// class Program
// {
//     static void Main()
//     {
//         using (ResourceHandler handler = new ResourceHandler())
//         {
//             Console.WriteLine("Using resource...");
//         }
//          // Automatically calls Dispose() here

//         Console.WriteLine("End of program.");
//     }
// }