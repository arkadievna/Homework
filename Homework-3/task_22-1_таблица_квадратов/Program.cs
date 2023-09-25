// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// первое решение
Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 0)
{
    for (int i = 1; i <= N; i++)
    {
        int square = i * i;
        Console.Write(square + " ");
    }
    Console.WriteLine();
}
else
{
    Console.WriteLine("Некорректное значение N!");
}