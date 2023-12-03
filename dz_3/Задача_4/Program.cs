// Задача_4



using System;

class Program
{
    static void Main()
    {
        // Введите натуральное число в диапазоне от 1 до 100000
        Console.Write("Введите натуральное число (от 1 до 100000): ");
        int inputNumber = int.Parse(Console.ReadLine());

        // Проверка на валидность введенного числа
        if (inputNumber < 1 || inputNumber > 100000)
        {
            Console.WriteLine("Число не соответствует диапазону от 1 до 100000.");
            return;
        }

        // Создаем массив цифр из числа
        int numberOfDigits = (int)Math.Floor(Math.Log10(inputNumber)) + 1;
        int[] digitsArray = new int[numberOfDigits];

        for (int i = numberOfDigits - 1; i >= 0; i--)
        {
            digitsArray[i] = inputNumber % 10;
            inputNumber /= 10;
        }

        // Выводим результат
        Console.Write("Массив цифр числа:");

        foreach (int digit in digitsArray)
        {
            Console.Write($"{digit} ");
        }
    }
}

