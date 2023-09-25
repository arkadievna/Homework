// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

using System;
class Program
{
    static void Main()
    {
        // создание массива из 8 элементов
        int[] array = new int[8];

        // заполнение массива значениями от 1 до 8
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }

        // вывод элементов массива через запятую
        Console.Write("Элементы массива:");
        Console.WriteLine(string.Join(", ", array)); // string.Join() объединяет элементы массива и разделяет их запятой и пробелом
    }
}


