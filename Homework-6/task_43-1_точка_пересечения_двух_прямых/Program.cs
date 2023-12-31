﻿// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем. 
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 > (-0,5; -0,5)

using System;

class Program // вход
{
    static void Main(string[] args) // начало программы
    {
        Console.Write("Введите значение b1: "); // запрос ввода значения первой точки первой прямой
        double b1 = double.Parse(Console.ReadLine() ?? "0"); // считывание введённой информации
        // переменная double позволяет работать с вещественными числами

        Console.Write("Введите значение k1: "); // запрос ввода значения второй точки первой прямой
        double k1 = double.Parse(Console.ReadLine() ?? "0"); // считывание введённой информации

        Console.Write("Введите значение b2: "); // запрос ввода значения первой точки второй прямой
        double b2 = double.Parse(Console.ReadLine() ?? "0"); // считывание введённой информации

        Console.Write("Введите значение k2: "); // запрос ввода значения второй точки второй прямой
        double k2 = double.Parse(Console.ReadLine() ?? "0"); // считывание введённой информации

        // вычисление координат точки пересечения по формуле
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;

        Console.WriteLine("Точка пересечения прямых: (" + x + "; " + y + ")"); // вывод в консоль результата
    }
}