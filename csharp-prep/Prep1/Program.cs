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

        Console.Write("What is your pourcentage? ");
        string pourcentage = Console.ReadLine();
        int percent = int.Parse(pourcentage);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Low score, please, try to work hard!");
        }


    }
}