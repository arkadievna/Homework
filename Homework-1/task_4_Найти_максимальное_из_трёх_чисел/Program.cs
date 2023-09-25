// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
string? numberString1 = Console.ReadLine();

Console.WriteLine("Введите второе число: ");
string? numberString2 = Console.ReadLine();

Console.WriteLine("Введите третье число: ");
string? numberString3 = Console.ReadLine();

int numberInt1 = Convert.ToInt32(numberString1);
int numberInt2 = Convert.ToInt32(numberString2);
int numberInt3 = Convert.ToInt32(numberString3);

if (numberInt1 == numberInt2 && numberInt2 == numberInt3)
{
Console.WriteLine("Числа равны");
}

else
{
int max = numberInt1;

if (numberInt2 > max) max = numberInt2;
if (numberInt3 > max) max = numberInt3;

Console.Write("Максимальное число: ");
Console.WriteLine(max);
}

