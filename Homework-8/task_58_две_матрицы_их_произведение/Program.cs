// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using System;

class Program
{
    static void Main(string[] args)
    {
        // Есть две матрицы, для которых инициализирую значения.
        int[,] matrix1 = {
            { 2, 4 },
            { 3, 2 }
        };

        int[,] matrix2 = {
            { 3, 4 },
            { 3, 3 }
        };

        // Определение размеров матриц.
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);

        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        /* Проверяю, можно ли выполнить умножение матриц,
        сравнивая кол-во столбцов первой матрицы с количеством строк второй матрицы. 
        Если они не равны, то умножение не возможно. */
        if (cols1 != rows2)
        {
            Console.WriteLine("Умножение матриц невозможно.");
            Console.ReadLine();
            return;
        }

        // Создаю новую матрицу `result` с размерами, соответствующими результирующей матрице.
        int[,] result = new int[rows1, cols2];

        // Выполняю умножение матриц.
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                int sum = 0;
                for (int k = 0; k < cols1; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                result[i, j] = sum;
            }
        }

        // Вывод результирующий матрицы.
        Console.WriteLine("Результирующая матрица:");

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
