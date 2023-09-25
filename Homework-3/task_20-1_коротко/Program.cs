// double Calc2DDist(int x1, int x2, int y1, int y2) // типы double должны соответствовать друг другу
// {
//     double res = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)); // типы double соответств. др. др., т.е. написаны и там и там
//     // Sqrt - извлечение корня квадратного 
//     return res;
// }

double findDistance(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y1 - y2, 2));
}

int x1 = int.Parse(Console.ReadLine() ?? "0");
int y1 = int.Parse(Console.ReadLine() ?? "0");
int x2 = int.Parse(Console.ReadLine() ?? "0");
int y2 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine(findDistance(x1, y1, x2, y2));