﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите число обозначающее день недели (от 1 до 7):");
   int n = Convert.ToInt32(Console.ReadLine());
   if ((n<0)||(n>7))
   {
    Console.WriteLine("Число не подходит");
   }
   else
   {
    if (n>5)
    {
        Console.WriteLine("Да, это выходной");
    }
    else
    {
        Console.WriteLine("Нет, это не выходной");
    }
   }
