// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите первое число:");
int number_A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int number_B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число:");
int number_C = Convert.ToInt32(Console.ReadLine());
int max=number_A;

if (number_B>max)  max=number_B;

if  (number_C>max)  max=number_C; 


Console.WriteLine($"Максимальное число {max}");
