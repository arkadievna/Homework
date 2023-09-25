// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int sum = CalculateDigitSum(number);
        Console.WriteLine("Сумма цифр числа: " + sum);
    }

    public static int CalculateDigitSum(int number)
    {
        int sum = 0;

        while (number > 0)
        {
            int digit = number % 10;
            sum += digit;
            number /= 10;
        }

        return sum;
    }
}
