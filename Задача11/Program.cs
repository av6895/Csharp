﻿// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// ● 456 -> 46
// ● 782 -> 72
// ● 918 -> 98 

int number = new Random().Next(100, 1000);
int num1 = number / 100;
int num2 = number % 10;
Console.WriteLine("из числа " + number + " остается " + num1 + num2);