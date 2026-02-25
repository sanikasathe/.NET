// See https://aka.ms/new-console-template for more information
using static System.Runtime.InteropServices.JavaScript.JSType;

//LINQ stands for Language Integrated Query.

//LINQ is a feature in C# that allows you to query data directly inside your program using simple and readable syntax.

//It is part of the .NET Framework and works with:

//Arrays

//Lists

//Collections

//Databases

//xml

//🔹 Why LINQ is Used?

//To filter data

//To sort data

//To group data

//To search data

//To transform data

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6 };

        var evenNumbers = numbers.Where(n => n % 2 == 0);

        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }
    }
}
