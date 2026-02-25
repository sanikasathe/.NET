// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
// Activity 2 : Multicast Delegate example in C#

using System;

class Program
{
    // Define a delegate 
    public delegate int Calculate(int number);

    // Method to calculate square
    public static int Square(int number)
    {
        Console.WriteLine("Square: " + (number * number));
        return number * number;
    }

    // Another method to calculate cube
    public static int Cube(int number)
    {
        Console.WriteLine("Cube: " + (number * number * number));
        return number * number * number;
    }

    static void Main(string[] args)
    {
       

        // Create an instance of the delegate and assign it to Square
        Calculate calculateDelegate = Square;

        // Add the Cube method to the delegate invocation list
        calculateDelegate += Cube;

        // Invoke the delegate
        int finalResult = calculateDelegate(3);

        Console.WriteLine("Final Returned Value: " + finalResult);

       
    }
}
