﻿// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// точка входа для исполнения программы
public class Program
{
    // объявление публичного статического метода "Main" 
    // на вход аргумент типа "string[]" на выход "void"
    public static void Main(string[] args)
    {
        // объявление и создание переменной array типа "double[]" с набором значений
        double[] array = { 1.2, 2.3, 3.4, 4.5, 5.6, 6.7 };

        // вывод текста на консоль
        Console.WriteLine("Массив вещественных чисел:");
        // вызов метода и передача ему параметра array
        PrintArray(array);

        // создание переменной difference типа "double" 
        // и присвоение ей значения, которое возвращает метод FindDifference(array)
        double difference = FindDifference(array);
        // вывод текста на консоль
        Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);
    }

    // объявление публичного статического метода "PrintArray" 
    // входной параметр типа "double[]"
    // public static void PrintArray(double[] array)
    // {
    //     // для каждого элемента "number" в массиве "array" выполнить следующий блок кода
    //     foreach (double number in array)
    //     {
    //         // вывод на консоль значения перемнной "number"
    //         Console.WriteLine(number);
    //     }
    // }

    // объявление статического метода PrintArray
    // принимает массив целых чисел и не возвращает никакого значения "void"
    public static void PrintArray(double[] array)
    {
        // вывод на консоль всех элементов массива в строку через запятую и пробел
        // метод string.Join объединяет элементы массива в одну строку, ставит между ними указанный разделитель
        Console.WriteLine(string.Join("; ", array));
    }


    // объявление публичного статического метода "FindDifference" 
    // входной параметр типа "double[]"
    // возвращает значение типа "double"
    public static double FindDifference(double[] array)
    {
        double min = array[0]; // объявление переменной min и присвоение ей значения первого элемента массива
        double max = array[0]; // объявление переменной max и присвоение ей значения первого элемента массива

        for (int i = 1; i < array.Length; i++) // цикл выполняется для каждого элемента массива со второго элемента
        {
            if (array[i] < min) // если текущий элемент массива меньше значения переменной min, выполнить следующий блок
            {
                min = array[i]; // присвоить переменной min значение текущего элемента массива
            }
            else if (array[i] > max) // в другом случае, если текущий элемент массива больше переменной max, выполнить следующий блок
            {
                max = array[i]; // присвоить переменной max значение текущего элемента массива
            }
        }

        return max - min; // возврат разницы между максимальным и минимальным значениями массива
    }
}