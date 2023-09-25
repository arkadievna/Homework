// Вывод сообщения и вызов метода CheckingCoordinates
string Prompt(string message)
{
    Console.WriteLine(message);
    string values = Console.ReadLine()??",";
    int quarter = Convert.ToInt32(values);

    return CheckingCoordinates(quarter); // внутри метода вызов другого метода
}

// Проверка четверти
string CheckingCoordinates(int quarter)
{
    switch(quarter)
    {
        case 1: return "(X > 0 ; Y > 0)";
        case 2: return "(X < 0 ; Y > 0)";
        case 3: return "(X < 0 ; Y < 0)";
        case 4: return "(X > 0 ; Y < 0)";
        default: return "0";
    }
}

Console.WriteLine(Prompt("Введите номер четверти: ")); // программа заключается в вызове метода Promt