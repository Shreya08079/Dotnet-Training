// using System;


// interface IPrint
// {
//     void Print();
// }


// interface IScan
// {
//     void Scan();
// }


// class PrinterScanner : IPrint, IScan
// {
//     public void Print()
//     {
//         Console.WriteLine("Printing document...");
//     }

//     public void Scan()
//     {
//         Console.WriteLine("Scanning document...");
//     }
// }


// class MultipleInheritance
// {
//     public static void Run()
//     {
//         PrinterScanner ps = new PrinterScanner();
//         ps.Print();
//         ps.Scan();
//     }
// }
using System;


class Bird
{
    //Base Class 
    public void Eat()
    {
        Console.WriteLine("Bird is eating");
    }
}

//Class for Singing bird inheriting Bird class

class SingingBird : Bird
{
    public void Sing()
    {
        Console.WriteLine("Bird can sing");
    }
}

//Class for Dancing bird inheriting Bird class
class DancingBird : Bird
{
    public void Dance()
    {
        Console.WriteLine("Bird can dance");
    }
}

//Class for Swimming bird inheriting Bird class
class SwimmingBird : Bird
{
    public void Swim()
    {
        Console.WriteLine("Bird can swim");
    }
}

//Class for Walking bird inheriting Bird class
class WalkingBird : Bird
{
    public void Walk()
    {
        Console.WriteLine("Bird can walk");
    }
}
//Runner class
class Multiple
{
   public static void Run()
    {
        //calling methods of different classes
        
        SingingBird b1 = new SingingBird();
        b1.Eat();
        b1.Sing();

        DancingBird b2 = new DancingBird();
        b2.Eat();
        b2.Dance();

        SwimmingBird b3 = new SwimmingBird();
        b3.Eat();
        b3.Swim();

        WalkingBird b4 = new WalkingBird();
        b4.Eat();
        b4.Walk();
    }
}
