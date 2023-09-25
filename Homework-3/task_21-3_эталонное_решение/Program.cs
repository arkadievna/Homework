using System;

public class Answer
{
    private static int Square(int number)
    {
        return number * number;
    }

    private static int SumSquare(int[] pointA, int[] pointB)
    {
        int sum = 0;
        for (int i = 0; i < pointA.Length; i++)
        {
            sum += Square(pointA[i] - pointB[i]);
        }
        return sum;
    }

    private static double Length(int[] pointA, int[] pointB)
    {
        double result = Math.Sqrt(SumSquare(pointA, pointB));
        return result;
    }

    public static void Main(string[] args) {
        int x1, x2, x3, y1, y2, y3;

        if (args.Length >= 6) {
            x1 = int.Parse(args[0]);
            x2 = int.Parse(args[1]);
            x3 = int.Parse(args[2]);
            y1 = int.Parse(args[3]);
            y2 = int.Parse(args[4]);
            y3 = int.Parse(args[5]);
        } else {
            x1 = 3;
            x2 = 6;
            x3 = 8;
            y1 = 2;
            y2 = 1;
            y3 = -7;
        }

        double result = Length(new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
        Console.WriteLine($"{result:F2}");
    }
}
