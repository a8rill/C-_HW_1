﻿//  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите целое число:");
int number_A = Convert.ToInt32(Console.ReadLine());
if (number_A % 2==0)
{
 Console.WriteLine($"Число {number_A} - чётное");
 }
else 
{
    Console.WriteLine($"Число {number_A} - нечётное");
}
