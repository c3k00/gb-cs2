﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num>99 && num<1000)
{
Console.WriteLine("-> " + num /10 % 10);
}

else Console.WriteLine("Неверное число " + num);