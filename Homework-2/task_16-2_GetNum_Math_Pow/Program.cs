int GetNum() // обернуто в метод запрос
{
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}
// ввод числа запрашивается дважды, 
// потому что метод `GetNum()` вызывается дважды: 
// первый раз для получения значения переменной `firstNum`, 
// второй раз для получения значения переменной `secondNum`.
int firstNum = GetNum(); // первый вызов
int secondNum = GetNum(); // второй вызов
// int Num3 = GetNum(); // третий

bool firstPow = firstNum == Math.Pow(secondNum, 2);
bool secondPow = secondNum == Math.Pow(firstNum, 2);
// Метод `Math.Pow()` возвращает результат возведения числа `x`(secondNum) в степень `y`(2)

Console.WriteLine(firstPow  || secondPow ? "Одно из чисел является квадратом второго" : "Ни одно из чисел не является квадратом другого");


