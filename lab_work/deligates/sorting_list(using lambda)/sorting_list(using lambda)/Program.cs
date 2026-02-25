// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
// Activity 4 : Sort List using Lambda Expression in C#

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        

        // Create a list of integers
        List<int> numbers = new List<int> { 5, 2, 8, 1, 4 };

        Console.WriteLine("Original List:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }

        // Sort list in ascending order using lambda
        numbers.Sort((a, b) => a.CompareTo(b));

        Console.WriteLine("\nSorted List (Ascending):");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }

        // Sort list in descending order using lambda
        numbers.Sort((a, b) => b.CompareTo(a));

        Console.WriteLine("\nSorted List (Descending):");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
    }
}
