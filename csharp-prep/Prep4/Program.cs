using System;
 using System.Collections.Generic;
using System.Runtime.InteropServices;
class Program
{
    static void Main(string[] args)
    {
    
    // Open list
    List<int> numbers = new List<int>();
      
    int user_number = -1;
    while (user_number != 0)
       {
        // Ask the user to give "numbers" integers to hold
        Console.Write("Enter a list of numbers, type 0 when finished. ");
       
        string user_response = Console.ReadLine();
        user_number = int.Parse(user_response);

        if (user_number != 0)
        {
            numbers.Add(user_number);
        }
       }

        // Part 1 compute the sum
        int sum = 0;
        
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}.");

        // Part 2 Average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}.");

        // Part 3 Max
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}.");
    }
}


