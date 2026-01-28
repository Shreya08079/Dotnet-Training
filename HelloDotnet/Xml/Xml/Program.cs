// using System;
// using System.IO;
// using System.Xml.Serialization;

// // Step 1: Create a public class
// public class Student
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public List<int> Marks { get; set; }
//     public int[] Scores { get; set; }

//     // Parameterless constructor (required)
//     public Student() { }
// }

// class Program
// {
//     static void Main()
//     {
//         // Step 2: Create object
//         Student s = new Student
//         {
//             Id = 1,
//             Name = "Shreya",
//             Marks = new List<int> { 85, 90, 88 },
//             Scores = new int[] { 88, 92, 84 }
//         };

//         // Step 3: Convert object to XML
//         XmlSerializer serializer = new XmlSerializer(typeof(Student));

//         using (StringWriter writer = new StringWriter())
//         {
//             serializer.Serialize(writer, s);
//             string xml = writer.ToString();

//             // Step 4: Print XML
//             Console.WriteLine(xml);
//         }
//     }
// }
// using System;
// using System.Xml.Linq;
// using Newtonsoft.Json;

// class Program
// {
//     static void Main()
//     {
//         // JSON string
//         string json = @"{
//             'Student': {
//                 'Id': 1,
//                 'Name': 'Shreya',
//                 'Marks': [85, 90, 88]
//             }
//         }";

//         var proceslist = from p in System.Diagnostics.Process.GetProcesses()
//                          select p.ProcessName;

//         // Convert JSON to XML
//         XNode xml = JsonConvert.DeserializeXNode(json, "Root");

//         // Print XML
//         Console.WriteLine(xml);
//     }
// }
