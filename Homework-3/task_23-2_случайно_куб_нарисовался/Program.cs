using System;

public class Answer
{
   static void ShowCube(int N)
    {
      // Введите свое решение ниже
       for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (i == 0 || i == N - 1 || j == 0 || j == N - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int N;

        if (args.Length >= 1) {
            N = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 6;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}
