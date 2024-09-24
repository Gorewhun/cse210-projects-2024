using System;
 using System.Collections.Generic;
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


       }
    }
}