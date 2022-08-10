﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели:");
int numberDay= Convert.ToInt32(Console.ReadLine());

if(numberDay > 0 && numberDay < 8) 
{
    if(numberDay == 6 || numberDay == 7) 
    {
        Console.WriteLine($"{numberDay} Выходной!");
    } 
    else 
    {
        Console.WriteLine($"{numberDay} Рабочий");
    }
} 
else 
{
    Console.WriteLine($"{numberDay} Нет такого дня");
}
