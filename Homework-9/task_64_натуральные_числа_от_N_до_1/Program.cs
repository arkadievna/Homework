// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System;

public class Program
{
    public static void Main()
    {
        // Запрос у пользователя значения N.
        Console.Write("Введите значение N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        
        // Рекурсивная функция принимает в качестве аргумента текущее число `n`.
        PrintNumbers(N);
    }
    
    public static void PrintNumbers(int n)
    {
        // Если `n` равно 0, функция возвращает управление.
        if (n == 0)
            return;
        
        // Вывод в консоль чисел от N до 1.
        Console.Write(n + ", ");
        
        // Или вывожу текущее число `n` и рекурсивно вызываю `PrintNumbers` с аргументом `n - 1`. 
        PrintNumbers(n - 1);
    }
}