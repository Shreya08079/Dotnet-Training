using System;
namespace Abstraction;


abstract class Employee
{
    public abstract void TaxCollection();
}

class USEmployee : Employee
{
    public override void TaxCollection()
    {
        Console.WriteLine("US Employee....");
    }
}

class IndianEmployee : Employee
{
    public override void TaxCollection()
    {
        Console.WriteLine("Indian Employee....");
    }

}

class AbstractionDemo
{
    public static void Run()
    {
        Employee emp1 = new USEmployee();
        Employee emp2 = new IndianEmployee();

        emp1.TaxCollection();
        emp2.TaxCollection();
    }
}