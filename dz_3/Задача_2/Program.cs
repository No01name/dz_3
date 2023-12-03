// Задача_2



using System;

class Program
{
    static void Main()
    {
        // Создаем массив из 10 целых чисел
        int[] numbers = new int[] { 2, 5, 8, 12, 17, 22, 30, 35, 40, 45 };

        // Переменная для отслеживания количества четных чисел
        int evenCount = 0;

        // Перебираем массив и проверяем каждое число
        foreach (int number in numbers)
        {
            // Если число четное, увеличиваем счетчик
            if (number % 2 == 0)
            {
                evenCount++;
            }
        }

        // Выводим результат
        Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");
    }
}

