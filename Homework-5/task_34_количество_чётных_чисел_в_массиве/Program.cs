﻿// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


// объявление публичного класса с именем Program
// основной класс в программе
public class Program
{
    // основной метод в программе, выполняется при старте 
    // принимает аргументы командной строки в виде массива строк "string args"
    public static void Main(string[] args)
    {
        // создание массива целых чисел
        // значения попадают в массив из метода GenerateRandomArray, который генерирует случайные числа
        int[] array = GenerateRandomArray(10); // в скобках количество случайных чисел

        // вывод в консоль текста
        Console.Write("Массив случайных трехзначных чисел: ");
        // метод выводит в консоль содержимое массива array
        PrintArray(array);

        // создание переменная count, в неё записывается результат работы метода CountEvenNumbers
        // метод считает количество четных чисел в массиве
        int count = CountEvenNumbers(array);
        // вывод в консоль количества чётных чисел
        Console.Write("Количество четных чисел: " + count);
    }

    // объявление статического метода GenerateRandomArray
    // принимает входной параметр "size" и возвращает массив целых чисел []
    public static int[] GenerateRandomArray(int size)
    {
        // класс Random используется для генерации случайных чисел
        Random random = new Random();
        // создание нового массива целых чисел размером size
        // им передается введенное значение
        int[] array = new int[size];

        // цикл "for" для инициализации элементов массива 
        // диапазон случайных чисел от 100 до 1000
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(100, 1000);
        }

        // метод возвращает созданный массив
        return array;
    }

    // объявление статического метода PrintArray
    // принимает массив целых чисел и не возвращает никакого значения "void"
    public static void PrintArray(int[] array)
    {
        // вывод на консоль всех элементов массива в строку через запятую и пробел
        // метод string.Join объединяет элементы массива в одну строку, ставит между ними указанный разделитель
        Console.WriteLine(string.Join(", ", array));
    }

    // объявление статического метода CountEvenNumbers
    // принимает в качестве входного параметра массив целых чисел и возвращает целое число
    public static int CountEvenNumbers(int[] array)
    {
        // присваивание переменной count значение 0
        int count = 0;

        // цикл foreach проходит по каждому элементу массива
        foreach (int number in array)
        {
            if (number % 2 == 0) // проверка на чётность
            {
                count++; // если элемент четный, то "count" увеличивается на 1
            }
        }

        // возврат количества четных чисел в input
        return count;
    }
}