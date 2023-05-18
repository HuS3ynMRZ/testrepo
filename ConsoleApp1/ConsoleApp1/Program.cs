using System;
class ConsoleApp1
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        Class1 daobject = new Class1("Valentin", "TeamLead");

        Console.WriteLine(daobject.name+" "+daobject.profession);

    }
}
