﻿//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.WriteLine("Введите первое число:");
int number_A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int number_B = Convert.ToInt32(Console.ReadLine());
if (number_A > number_B)
{
    Console.Write($"Максимальное число: {number_A} Минимальное число: {number_B}");
}

else 
{
    Console.WriteLine($"Минимальное число: {number_A} Максимальное число: {number_B}");
}

