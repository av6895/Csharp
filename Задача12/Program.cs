﻿// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то 
// программа выводит остаток от деления.
// ● 34, 5 -> не кратно, остаток 4
// ● 16, 4 -> кратно

Console.WriteLine("Введите первое число: ");
int numberA =int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int numberB =int.Parse(Console.ReadLine()!);

int numberC = numberA % numberB;

if(numberA % numberB == 0)
{
  Console.WriteLine("второе число кратно первому");
}
else
{
  Console.WriteLine("Второе число не кратно первому, остаток " + numberC);
}