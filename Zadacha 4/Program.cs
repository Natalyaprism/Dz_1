﻿// Напишите программу, которая принимает на вход три числа
//и выдаёт максимальное из этих чисел.
//  2, 3, 7 -> 7
//  44 5 78 -> 78
//  22 3 9 -> 22

int a, b, c;
Console.WriteLine("Введите 3 целых числа");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b>a)
{
    max = b;
}
if (c>max)
{
    max = c;
}
Console.WriteLine("Максимальное число = "+max);