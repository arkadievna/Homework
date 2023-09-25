// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

int numA = int.Parse(Console.ReadLine()??"0");
int numB = int.Parse(Console.ReadLine()??"0");
// int result = numB % numA;
if (numB % numA == 0) // if (result == 0)
{
    Console.WriteLine("Второе число кратно первому.");
}
else 
{
    Console.WriteLine("Второе число не кратно первому. Остаток от деления: " + numB % numA);
    // Console.WriteLine("Второе число не кратно первому. Остаток от деления: " + result);
}