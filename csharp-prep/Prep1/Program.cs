using System;
using System.Runtime.ExceptionServices;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for there name.
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your first name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last} ");
    }
}