// See https://aka.ms/new-console-template for more information
//Calculator using delegates

//delegate is a type that represents references to methods with a particular parameter list and return type.
//When you instantiate a delegate, you can associate its instance with any method with a compatible signature and return type.
//You can invoke the method through the delegate instance.

using System;

class Program
{
    // Define a delegate 
    delegate int Operation(int a, int b);
    static void Main()
    {
        // Create instances of the delegate for different operations
        Operation add = (a, b) => a + b;
        Operation subtract = (a, b) => a - b;
        Operation multiply = (a, b) => a * b;
        Operation divide = (a, b) => a / b;

        // Get user input
        Console.WriteLine("Enter first number:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int num2 = int.Parse(Console.ReadLine());
        // Perform operations and display results
        Console.WriteLine($"Addition: {add(num1, num2)}");
        Console.WriteLine($"Subtraction: {subtract(num1, num2)}");
        Console.WriteLine($"Multiplication: {multiply(num1, num2)}");
        Console.WriteLine($"Division: {divide(num1, num2)}");
    }
}
