﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число N: ");
int N = Int32.Parse(Console.ReadLine());

Console.WriteLine("Таблица кубов от 1 до {0}:", N); // {0} == N
for (int i = 1; i <= N; i++)
     {
        int cube = i * i * i;
        Console.Write("{0} ", cube);
    }