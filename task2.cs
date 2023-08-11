using System;

public class Salam
{
    public void Hello(string name)
    {
        Console.WriteLine($"Hello {name}");
    }

    public void Hello(string name, string surname)
    {
        Console.WriteLine($"Hello {name} {surname}");
    }

    public void Hello(string name, string surname, int age)
    {
        Console.WriteLine($"Hello {name} {surname} - {age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        

        Console.WriteLine("Enter a name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter a surname:");
        string surname = Console.ReadLine();

        Console.WriteLine("Enter an age:");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine(name);
        Console.WriteLine(name+" "+surname);
        Console.WriteLine(name+" "+surname+" "+age);
    }
}
