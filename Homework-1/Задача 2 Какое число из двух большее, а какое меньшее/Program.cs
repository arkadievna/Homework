// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число: ");
string? numberString1 = Console.ReadLine();

Console.WriteLine("Введите второе число: ");
string? numberString2 = Console.ReadLine();

int numberInt1 = Convert.ToInt32(numberString1);
int numberInt2 = Convert.ToInt32(numberString2);

if (numberInt1 > numberInt2)
{
    Console.WriteLine("Первое число больше второго");
}
else if (numberInt1 == numberInt2)
{
    Console.WriteLine("Числа равны");
}
else
{
    Console.WriteLine("Второе число больше, чем первое");
}
