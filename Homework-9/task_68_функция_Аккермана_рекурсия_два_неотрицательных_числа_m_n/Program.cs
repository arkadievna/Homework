// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System;

public class Program
{
    public static void Main()
    {
        // Запрос у пользователя значения M.
        Console.Write("Введите значение m: ");
        int m = Convert.ToInt32(Console.ReadLine());

        // Запрос у пользователя значения N.
        Console.Write("Введите значение n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        // Вызов функции Аккермана с введенными значениями. Сохранение результата в переменную result.
        int result = Ackermann(m, n);
        
        // Результат вычисления функции Аккермана выводится в консоль.
        Console.WriteLine("A(" + m + ", " + n + ") = " + result);
    }
    
    public static int Ackermann(int m, int n)
    {
        // Если m равно 0, то возвращаем n + 1.
        if (m == 0)
            return n + 1;
        
        // Если m больше 0 и n равно 0, то рекурсивно вызываю Аккерман с аргументами m - 1 и 1.
        if (m > 0 && n == 0)
            return Ackermann(m - 1, 1);
        
        // Если m больше 0 и n больше 0, то рекурсивно вызываю Аккерман с аргументами m - 1 и m, n - 1.
        if (m > 0 && n > 0)
            return Ackermann(m - 1, Ackermann(m, n - 1));
        
        // Если ни одно из условий не выполняется, возвращается 0.
        return 0;
    }
}