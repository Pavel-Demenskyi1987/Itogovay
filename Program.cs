
using System;

class Program
{
    static void Main()
    {
        string[] randomStrings = GenerateRandomStrings(10, 5);

        Console.WriteLine("Исходные случайные строки: " + string.Join(", ", randomStrings));
    
    }
}