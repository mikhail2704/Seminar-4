﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Write("Введите первое число:");
double a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
double b = Convert.ToInt32(Console.ReadLine());
double sim = Math.Pow(a,b);
Console.Write($"{a}^{b}={sim}");
f