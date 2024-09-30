using System;

class Program
{
    static void Main(string[] args)
    {
        List<double> x = new();
        // x = [24.0, 25.0, 26.0];

        Console.WriteLine("Hello Sandbox World!");  

        // Gather data to fill up a list

        double input = -1;
        while(input != 0)
        {
            Console.Write("Enter something: ");
            string input_string = Console.ReadLine();
            input = double.Parse(input_string);
            x.Add(input);
        }
       
        foreach (double number in x)
        {
            Console.WriteLine(number);
        }    
    }

}