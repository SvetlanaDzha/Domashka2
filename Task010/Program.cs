﻿// // Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трехзначное число");
int number  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Второй цифрой числа {number} является {number / 10 % 10} ");

