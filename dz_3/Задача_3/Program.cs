// Задача_3



using System;

class Program
{
    static void Main()
    {
        // Создаем массив вещественных чисел
        double[] numbers = { 3.14, 2.71, 6.66, 4.56, 8.99 };

        // Находим максимальный и минимальный элементы массива
        double max = numbers[0];
        double min = numbers[0];

        foreach (double num in numbers)
        {
            if (num > max)
            {
                max = num;
            }

            if (num < min)
            {
                min = num;
            }
        }

        // Находим разницу между максимальным и минимальным элементами
        double difference = max - min;

        // Выводим результат
        Console.WriteLine($"Максимальный элемент: {max}");
        Console.WriteLine($"Минимальный элемент: {min}");
        Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");
    }
}

