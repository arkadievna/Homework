// Вывод сообщения и вызов метода OutputSquares
void Prompt(string message)
{
    Console.WriteLine(message);
    string values = Console.ReadLine()??",";
    int number = Convert.ToInt32(values);

    OutputSquares(number);
}

// Расчёт квадратов и составление таблицы
void OutputSquares(int number) // вызов метода в методе - вызов метода печати квадратов
{
    Console.Clear();

    int currentNumber = 0;
    int currentNumberSquare;
    int cursor = 0;

    while (currentNumber <= number)
    {
        currentNumberSquare = (int)Math.Pow(currentNumber, 2);

        Console.SetCursorPosition(cursor, 0); // идёт выставление чисел по одному в каждой строке по очереди
        Console.Write(currentNumber);

        Console.SetCursorPosition(cursor, 1);
        Console.Write(currentNumberSquare);

        cursor = Console.CursorLeft + 3; // со смещение курсора от числа на 3 пробела

        currentNumber++;
    }
}

Prompt("Введите число: ");