using System;
using System.IO;

class FileReader
{
    static void Main()
    {
        string filePath = "data.txt";

        try
        {
            StreamReader reader = new StreamReader(filePath);
            string content = reader.ReadToEnd();
            Console.WriteLine(content);
            reader.Close();
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: File not found.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Error: Access to the file is denied.");
        }
        finally
        {
            Console.WriteLine("File read operation completed.");
        }
    }
}
