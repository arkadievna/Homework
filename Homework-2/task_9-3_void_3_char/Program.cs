void Variant1()
{
Console.WriteLine("Способ 1");
System.Random numberGenerator = new System.Random(); 
int number = numberGenerator.Next(10,100); 
Console.WriteLine(number);

int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit > secondDigit)
{
    Console.WriteLine(firstDigit);
}
else
{
    Console.WriteLine(secondDigit);
}
} // скобки показывают, что этот кусок кода одно целое

void Variant2()
{
Console.WriteLine("Способ 2");
System.Random numberGenerator2 = new System.Random(); 
int number2 = numberGenerator2.Next(10,100); 
Console.WriteLine(number2);
Console.WriteLine((number2/10 > number2%10)?(int)(number2/10):(int)(number2%10));
}

void Variant3()
{
Console.WriteLine("Способ 3");

System.Random numberGenerator3 = new System.Random(); 
int number3 = numberGenerator3.Next(10,100); 
Console.WriteLine(number3);

char[] digitChar = number3.ToString().ToCharArray(); // преобразовать в строку и разобрать по цифрам
Console.WriteLine(digitChar[0]>digitChar[1]?digitChar[0]:digitChar[1]);
// если условие верное, тогда выполняется условие 1; если не верное, тогда вариант 2
}

Variant1();
Variant2();
Variant3();