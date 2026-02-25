// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information
// Activity : Replace Methods with Lambda Expressions

using System;

class Program
{
    // Define delegate
    public delegate void Greet(string name);

    static void Main(string[] args)
    {
        Console.WriteLine("Activity : Lambda Expression Example");

        // Lambda for Hello
        Greet greetDelegate = (name) =>
        {
            Console.WriteLine("Hello " + name);
        };

        // Lambda for Goodbye
        greetDelegate += (name) =>
        {
            Console.WriteLine("Goodbye " + name);
        };

        // Invoke delegate
        greetDelegate("Sanika");

       
    }
}