Console.WriteLine("Введите число: ");

// вводим число сразу вмассив char и присваиваем массив char в перменную digits
char[] digits = Console.ReadLine().ToCharArray();

// проверка наличия третьей цифры во введённом числе через длинну массива digits[]
if (digits.Length > 2)
{
    // выводим элемент массива с индексом 2
    Console.Write("Третья цифра в числе: ");
    Console.Write(digits);
    Console.Write(", равняется: ");
    Console.WriteLine(digits[2]);
}
else 
{
    // выводим результат, если введено двухзначное или однозначное число
    Console.Write("Третья цифра в числе: ");
    Console.Write(digits);
    Console.WriteLine(", отсутствует!");
}