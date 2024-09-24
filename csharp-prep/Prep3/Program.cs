using System;

class Program
{
    static void Main(string[] args)
    {
        // Part 1 and 2, user chooses the number

        // Console.Write("What is the magic number? ");
        // int magic_number = int.Parse(Console.ReadLine());

        // Part 3, Random number generator
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1,101);


        int guess = -1;

        // While loop to keep user guessing the magic number
        while (guess != magic_number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magic_number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magic_number < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}