// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// РЕШЕНИЕ НЕВЕРНОЕ!
//Console.WriteLine("Введите число");
// int number  = Convert.ToInt32(Console.ReadLine());


// if (number / 100 > 0) 
// {
//     Console.WriteLine($"Третьей цифрой числа {number} является цифра {number / 100 % 10}");
// }
// else 
// {
//     Console.WriteLine($"У числа {number} нет третьей цифры");
// }

//ВЕРНОЕ РЕШЕНИЕ:

Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberX = Convert.ToString(number);

if (numberX.Length > 2)
{
  Console.WriteLine("третья цифра " + numberX[2]);
}
else 
{
  Console.WriteLine(" третьей цифры нет");
}