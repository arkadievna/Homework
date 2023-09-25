﻿// не рабочий вариант решения
// в решении у преподавателя было res/10 -- это из трёхзначного число делает двухзначное 
// и выводит две цифры -- первую и вторую
// если прописать res/100, то выводить из трёхзначного числа будет первую
// если ввесли четырёхзначное и далее число, то показывает всегда 0

// приглашение консоли ввести число
Console.WriteLine("Введите положительное число.");

// создаём переменную num и с консоли вводим её значение
// при этом сразу проверяем на null и конвертируем в int
int num = int.Parse(Console.ReadLine()??"0");

// вычисляем разрядность числа с помощью десятичного логарифма
double digit = Math.Log10(num);
// конвертируем double -> int и отбрасываем дробную часть
digit = (int)digit;

// проверяем введённое число, оно должно быть 3-х значное или больше
if (digit > 1)
{
    // устанавливаем счётчик
    int count = 1;
    // объявляем переменную 
    int res = num;
    while (count < digit - 1)
    {
        // отбрасываем число до 3 знаков
        res = res/100;
        count++;
    }
    // выводим последнюю цифру числа
    Console.Write("Третья цифра в числе: ");
    Console.Write(num);
    Console.Write(", равняется: ");
    Console.WriteLine(res/100);
}
else
{
    // выводим результат, если введено двухзначное или однозначное число
    Console.Write("Третья цифра в числе: ");
    Console.Write(num);
    Console.WriteLine(", отсутствует!");
}
