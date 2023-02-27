using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Список рядків
        List<string> strings = new List<string> { "Hello", "World", "from", "Maksym" };

        // Створення делегата за допомогою лямбда-виразу
        Func<string, int> stringLength = s => s.Length;

        // Використання делегата для обробки списку рядків
        List<int> stringLengths = strings.Select(stringLength).ToList();

        // Виведення результатів
        foreach (int length in stringLengths)
        {
            Console.WriteLine(length);
        }
    }
}

