// перемудрёное решение

Console.WriteLine("Введите число");
long number = long.Parse(Console.ReadLine());

// проверка, что 3 и больше цифр в числе
if (number < 100 )
{
    Console.WriteLine("В числе меньше 3 цифр.");
}

else
{
    // создание массива
    long[] temp = new long[10]; // каждый разряд числа в отдельную ячейку массива
    // инициируем дополнительные переменные - флаги
    int i = 1;
    long j = 100;
    long k = 10;
    int thirdNumber = -2;
    // расскладываем число на цифры с помощью дополнительных переменных
    temp[0] = number % 10;
    number -= number % 10;
    do
    {
        temp[i] = (number % j) / k;
        number -= (number % j);
        i++;
        j *= 10;
        k *= 10;
        thirdNumber++;
    }
    while (!(number == 0));

    Console.WriteLine("Третья цифра: " + temp[thirdNumber]);
}
