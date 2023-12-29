
using System;

class Program
{
    static void Main()
    {
        string[] randomStrings = GenerateRandomStrings(10, 5);

        Console.WriteLine("Исходные случайные строки: " + string.Join(", ", randomStrings));
    
    }

    static string[] GenerateRandomStrings(int count, int maxLength)
    {
        Random random = new Random();
        string[] randomStrings = new string[count];

        for (int i = 0; i < count; i++)
        {
            int length = random.Next(1, maxLength + 1);
            char[] chars = new char[length];

            for (int j = 0; j < length; j++)
            {
                chars[j] = (char)random.Next('a', 'z' + 1);
            }

            randomStrings[i] = new string(chars);
        }

        return randomStrings;
    }
}