﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

// Console.Write("Введите элементы(через пробел): ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int countPozitive = 0; 
// int countNegativ = 0;
 
// Console.WriteLine();
// Console.WriteLine("Отсортированный массив: ");
// Array.Sort(arr);
 
// foreach (var i in arr)
// {
//     Console.Write("{0}; ", i);
// }

// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > 0)
//     {
//         countPozitive++;
//     }
//     else
//     {
//         countNegativ++;
//     }
// }


// Console.WriteLine($"Кол-во элементов больше 0: {countPozitive}");
// Console.WriteLine($"Кол-во элементов меньше 0: {countNegativ}");



////////////////////////////////////////////////////////////////////

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("Введите переменную b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите переменную k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите переменную b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите переменную k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());

// double x = -(b1 - b2) / (k1 - k2);
// double y = k1 * x + b1;

// Console.Write($"\n Точка пересечения двух прямых: [{x},{y}]");