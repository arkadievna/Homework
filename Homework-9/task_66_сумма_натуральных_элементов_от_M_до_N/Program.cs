// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;

public class Program
{
    public static void Main()
    {
        // Запрос у пользователя значения M.
        Console.Write("Введите значение M: ");
        int M = Convert.ToInt32(Console.ReadLine());
        
        // Запрос у пользователя значения N.
        Console.Write("Введите значение N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        
        int sum = 0;
        // Цикл для перебора всех чисел от M до N.
        for (int i = M; i <= N; i++)
        {
            // На каждой итерации добавляю текущее число к переменной sum.
            sum += i;
        }
        
        // Вывод результата в консоль.
        Console.WriteLine("Сумма натуральных элементов в промежутке от M до N: " + sum);
    }
}