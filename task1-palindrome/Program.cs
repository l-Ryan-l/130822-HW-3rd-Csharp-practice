﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Palindrome (string number)
{
  if (number[0] == number[4] && number[1] == number[3])
  {
    Console.WriteLine($"Ваше число: {number} - палиндром!");
  }
  else Console.WriteLine($"Ваше число: {number} - не явялется палиндромом.");
}

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine()!;

if (number.Length == 5)
{
  Palindrome(number);
}
else Console.WriteLine($"Введенное число не пятизначное. Попробуйте еще раз.");
