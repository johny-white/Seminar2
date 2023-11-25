﻿﻿using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите координаты точки (X и Y):");

        // Ввод координат с клавиатуры
        Console.Write("Введите X: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите Y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        // Проверка условия X ≠ 0 и Y ≠ 0
        if (x == 0 || y == 0)
        {
            Console.WriteLine("Ошибка: X и Y должны быть не равны нулю.");
        }
        else
        {
            // Определение четверти
            int quadrant = DetermineQuadrant(x, y);

            // Вывод результата
            Console.WriteLine($"Точка находится в {quadrant} четверти.");
        }
    }

    // Метод для определения номера координатной четверти
    static int DetermineQuadrant(double x, double y)
    {
        if (x > 0 && y > 0)
        {
            return 1;
        }
        else if (x < 0 && y > 0)
        {
            return 2;
        }
        else if (x < 0 && y < 0)
        {
            return 3;
        }
        else
        {
            return 4;
        }
    }
}