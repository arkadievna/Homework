int num1 = int.Parse(Console.ReadLine()??"0");
int num2 = int.Parse(Console.ReadLine()??"0");

Console.WriteLine((num2%num1==0)?true:num2%num1); 
// если остаток от деления равен == нулю 0, то выводит true
// если нет, то результат деления
