// 12345

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

int num1 = number / 10000;
int num2 = (number / 1000) % 10;

int num4 = (number / 10) % 10;
int num5 = number % 10;

if (number / 100000 != 0) // нужно придумать как проверить делением, что число пятизначное
// сейчас любо число до 6 знаков проходит проверку на палиндром
{
    Console.WriteLine("Вы ввели некорректное число.");
}

if (num1 == num5 && num2 == num4)
{
    Console.WriteLine("Это палиндром.");
}

else
{
    Console.WriteLine("Это не палиндром.");
}
