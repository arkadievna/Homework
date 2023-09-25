using System;

public class Answer
{
    static void ShowCube(int N)
    {
        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine(Cube(i));
        }
    }

    public static int Cube(int number)
    {
        return number * number * number;
    }

      static public void Main(string[] args) {
        int N;

        if (args.Length >= 1) {
            N = int.Parse(args[0]);
        } else {
            N = 6;
        }

        ShowCube(N);
    }
}
