﻿Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine() ?? "");
int count = 2;
if (num == 1)
{
    Console.WriteLine("Четных чисел нет");
}
while (count <= num)
{
    Console.Write($"{count} ");
    count +=2;
}
Console.WriteLine();
