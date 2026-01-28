using System;
using System.Collections.Generic;

public class Person
{
    
    public string? Name { get; set; }
    public string? Address { get; set; }
    public int Age { get; set; }
}

public class PersonImplementation
{
    public string GetName(IList<Person> person)
    {
        string result = "";

        foreach (Person p in person)
        {
            result += p.Name + " " + p.Address + " ";
        }

        return result.Trim();
    }

    public double Average(IList<Person> person)
    {
        int sum = 0;

        foreach (Person p in person)
        {
            sum += p.Age;
        }

        return (double)sum / person.Count;
    }

    public int Max(IList<Person> person)
    {
        int maxAge = person[0].Age;

        foreach (Person p in person)
        {
            if (p.Age > maxAge)
            {
                maxAge = p.Age;
            }
        }

        return maxAge;
    }
}

public class Program
{
    public static void Main()
    {
        IList<Person> p = new List<Person>();

        p.Add(new Person { Name = "Shreya", Address = "UCIL", Age = 21 });
        p.Add(new Person { Name = "Xoxo", Address = "Mumbai", Age = 22 });
        p.Add(new Person { Name = "Yoyo", Address = "Pune", Age = 25 });
        p.Add(new Person { Name = "Jen", Address = "Iran", Age = 33 });

        PersonImplementation impl = new PersonImplementation();

        Console.WriteLine(impl.GetName(p));
        Console.WriteLine(impl.Average(p));
        Console.WriteLine(impl.Max(p));
    }
}
