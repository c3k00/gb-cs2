// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 6 || num == 7) Console.WriteLine("Выходной");
else if (num >= 1 && num <= 5) Console.WriteLine("Вам сегодня на работу");
else if (num > 7) Console.WriteLine("Такого дня нет");
else Console.WriteLine("error");