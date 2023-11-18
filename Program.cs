﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. 

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите целое положительное число");
int n = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(n);

void NaturalNumbers(int n)
{
    if (n == 0) return;
    Console.Write($"{n} ");
    NaturalNumbers(n - 1);
}

