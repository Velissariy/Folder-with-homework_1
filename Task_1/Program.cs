﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;

if ( numberA > numberB)
{
  max = numberA;
  min = numberB;
  Console.Write("max = "); 
  Console.WriteLine(max);
  Console.Write("min = ");
  Console.Write(min);
}
if ( numberA < numberB)
{
  max = numberB;
  min = numberA;
  Console.Write("max = "); 
  Console.WriteLine(max);
  Console.Write("min = ");
  Console.Write(min);
}