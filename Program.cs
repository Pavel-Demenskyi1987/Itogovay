
using System;

class Program
{
    static void Main()
    {
        string[] randomStrings = GenerateRandomStrings(10, 5);

        string[] resultStrings = FilterStrings(randomStrings);

        Console.WriteLine("Исходные случайные строки: " + string.Join(", ", randomStrings));
        Console.WriteLine("Отфильтрованные строки: " + string.Join(", ", resultStrings));
    
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

    static string[] FilterStrings(string[] inputStrings)
    {
        int resultCount = 0;
        for (int i = 0; i < inputStrings.Length; i++)
        {
            if (inputStrings[i].Length <= 3)
            {
                resultCount++;
            }
        }

        string[] resultStrings = new string[resultCount];
        int index = 0;

        for (int i = 0; i < inputStrings.Length; i++)
        {
            if (inputStrings[i].Length <= 3)
            {
                resultStrings[index] = inputStrings[i];
                index++;
            }
        }

        return resultStrings;
    }
}