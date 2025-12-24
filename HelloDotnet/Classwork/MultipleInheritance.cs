using System;


interface IPrint
{
    void Print();
}


interface IScan
{
    void Scan();
}


class PrinterScanner : IPrint, IScan
{
    public void Print()
    {
        Console.WriteLine("Printing document...");
    }

    public void Scan()
    {
        Console.WriteLine("Scanning document...");
    }
}

// Main Program
class MultipleInheritance
{
    static void Run()
    {
        PrinterScanner ps = new PrinterScanner();
        ps.Print();
        ps.Scan();
    }
}
