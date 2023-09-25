// для того, чтобы один из способой деактивировать не удаля, не стирая, не превращая в комментарий,
// есть метод, который не даёт коду работать

// оборачивание методом
void Variant1() // void - тишина - скобки показывают, что это метод
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
// чтобы вызвать нужный вариант, нужно написать какой вариант вызвать

Variant1();
// Variant2();
// могут работать или оба варианта
// или любую из этих двух строк можно закоментить и закоменченый вариант не будет срабатывать