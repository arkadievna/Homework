// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// при этом решении выходит третья цифра с конца числа
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
    
int digitCount = number.ToString().Length;

if (digitCount < 3) 
{
Console.WriteLine("Третьей цифры нет");
} 

else 
{
int thirdDigit = (number / 100) % 10;
Console.WriteLine($"Третья цифра числа {number} - {thirdDigit}");
}

