﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа:");
int b = Convert.ToInt32(Console.ReadLine());
int sum = 1;
for (int i = 0; i<b ;i++)
   {
   sum=sum*a;
   }
Console.WriteLine(sum );