// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число: ");
string? numberString = Console.ReadLine();

int numberInt = Convert.ToInt32(numberString);

if (numberInt % 2 == 0) 
{
    Console.WriteLine("Число чётное");
} 
else 
{
    Console.WriteLine("Число нечётное");
}