using System;

public class Answer
{
    static bool IsPalindrome(int number)
    {
      // Введите свое решение ниже
      int originalNumber = number;
        int reversedNumber = 0;

        while (number != 0)
        {
            int remainder = number % 10;
            reversedNumber = reversedNumber * 10 + remainder;
            number /= 10;
        }

        return originalNumber == reversedNumber;
      
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) 
      {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 64546;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}