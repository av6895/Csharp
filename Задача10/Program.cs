﻿//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number =int.Parse(Console.ReadLine()!);


int num1 = number % 100;
int num2 = num1 / 10;
Console.WriteLine(num2);