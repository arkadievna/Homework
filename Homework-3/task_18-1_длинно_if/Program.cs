// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
// int quarter = Int32.Parse(Console.ReadLine());
string? numberString = Console.ReadLine();
int numberInt = Convert.ToInt32(numberString);

// switch (quarter)
// {
//     case 1:
//         Console.WriteLine("Диапазон координат на оси X: от 0 до бесконечности, на оси Y: от 0 до бесконечности.");
//         break;
//     case 2:
//         Console.WriteLine("Диапазон координат на оси X: от минус бесконечности до 0, на оси Y: от 0 до бесконечности.");
//         break;
//     case 3:
//         Console.WriteLine("Диапазон координат на оси X: от минус бесконечности до 0, на оси Y: от минус бесконечности до 0.");
//         break;
//     case 4:
//         Console.WriteLine("Диапазон координат на оси X: от 0 до бесконечности, на оси Y: от минус бесконечности до 0.");
//         break;
//     default:
//         Console.WriteLine("Невалидный номер четверти.");
//         break;

if (numberInt == 1)
{
    Console.WriteLine("Диапазон координат на оси X: от 0 до бесконечности, на оси Y: от 0 до бесконечности.");
}

if (numberInt == 2)
{
    Console.WriteLine("Диапазон координат на оси X: от минус бесконечности до 0, на оси Y: от 0 до бесконечности.");
}

if (numberInt == 3)
{
    Console.WriteLine("Диапазон координат на оси X: от минус бесконечности до 0, на оси Y: от минус бесконечности до 0.");
}

if (numberInt == 4)
{
    Console.WriteLine("Диапазон координат на оси X: от 0 до бесконечности, на оси Y: от минус бесконечности до 0.");
}

if (numberInt > 4 || numberInt < 1)
{
    Console.WriteLine("Невалидный номер четверти.");
}