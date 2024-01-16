using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        Console.Write("What is your first name?");
        string FirstName = Console.ReadLine();
        Console.Write("What is your family name?");
        string FamName = Console.ReadLine();

        Console.WriteLine($"Your name is {FamName}, {FirstName} {FamName}");


    }
}