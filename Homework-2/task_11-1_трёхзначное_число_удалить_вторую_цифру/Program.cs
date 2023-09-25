// Напишите программу, которая принимает на вход трёхзначное число 
// удаляет вторую цифру и на выходе показывает число без второй цифры.
// 237 -> 27

int num = new System.Random().Next(100, 1000); // 100-1000 потому что рандомное трёхзначное число
Console.WriteLine(num); // выведет в консол рандомное трёхзначное число
int firstDigit = num/100;
int lastDigit = num%10;
num = firstDigit*10+lastDigit;
Console.WriteLine(num);