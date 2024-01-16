using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();
        
        
        int userNum = -1;
        while (userNum != 0)
        {
            Console.WriteLine("Enter a number (0 to quit): ");
            
            string userResponse = Console.ReadLine();
            userNum = int.Parse(userResponse);
            
            
            if (userNum != 0)
            {
                numbers.Add(userNum);
            }
        }

        
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine(sum);

        
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine(average);

        
        
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                
                max = number;
            }
        }

        Console.WriteLine(max);
    }
}