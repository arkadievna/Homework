// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] arr = new int[4, 4];
        int num = 1;
        int n = 4;
        // Переменные для отслеживания границ заполняемой области массива.
        int rowMin = 0;
        int rowMax = n - 1;
        int colMin = 0;
        int colMax = n - 1;
        
        /* Заполняю массив числами от 1 до 16 спиральным образом.
         По часовой стрелке, заполняя верхнюю строку слева направо, 
         правый столбец сверху вниз, 
         нижнюю строку справа налево и 
         левый столбец снизу вверх, 
         пока не заполнится весь массив.
        */
        while (num <= n * n)  
        {
            // Заполняю верхнюю строку слева направо.
            for (int i = colMin; i <= colMax; i++)
            {
                arr[rowMin, i] = num++;
            }
            rowMin++;

            // Заполняю правый столбец сверху вниз.
            for (int i = rowMin; i <= rowMax; i++)
            {
                arr[i, colMax] = num++;
            }
            colMax--;

            // Заполняю нижнюю строку справа налево.
            for (int i = colMax; i >= colMin; i--)
            {
                arr[rowMax, i] = num++;
            }
            rowMax--;

            // Заполняю левый столбец снизу вверх.
            for (int i = rowMax; i >= rowMin; i--)
            {
                arr[i, colMin] = num++;
            }
            colMin++;
        }

        // Вывожу массив.
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(arr[i, j].ToString().PadLeft(2, '0') + " ");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}