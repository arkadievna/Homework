// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

        Console.WriteLine("Введите координаты первой точки: ");
Console.Write("x1: ");
double x1 = Double.Parse(Console.ReadLine());
Console.Write("y1: ");
double y1 = Double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
Console.Write("x2: ");
double x2 = Double.Parse(Console.ReadLine());
Console.Write("y2: ");
double y2 = Double.Parse(Console.ReadLine());

double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
Console.WriteLine($"Расстояние между точками (x1:{x1}, y1:{y1}) и (x2:{x2}, y2:{y2}): {distance}");