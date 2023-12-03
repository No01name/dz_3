// Задача_1



using System;

class Program
{
    static void Main()
    {
        // Создаем массив из 10 целых чисел от 1 до 100
        int[] array = GenerateArray();

        // Находим количество элементов в отрезке [20, 90]
        int count = CountElementsInRange(array, 20, 90);

        // Выводим результат
        Console.WriteLine($"Количество элементов в отрезке [20, 90]: {count}");
    }

    static int[] GenerateArray()
    {
        int[] array = new int[10];
        Random random = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101); // Генерируем случайное число от 1 до 100
        }

        return array;
    }

    static int CountElementsInRange(int[] array, int minValue, int maxValue)
    {
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            // Проверяем, остается ли значение в отрезке [20, 90]
            if (array[i] >= minValue && array[i] <= maxValue)
            {
                count++;
            }
        }

        return count;
    }
}

