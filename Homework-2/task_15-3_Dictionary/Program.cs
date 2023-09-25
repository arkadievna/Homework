// с помощью Dictionary()

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> daysOfWeek = new Dictionary<int, string>()
        {
            { 1, "Понедельник" },
            { 2, "Вторник" },
            { 3, "Среда" },
            { 4, "Четверг" },
            { 5, "Пятница" },
            { 6, "Суббота" },
            { 7, "Воскресенье" }
        };

        Console.Write("Введите цифру от 1 до 7 для обозначения дня недели: ");
        int dayNumber = Convert.ToInt32(Console.ReadLine());

        if (daysOfWeek.ContainsKey(dayNumber))
        {
            string dayName = daysOfWeek[dayNumber];
            bool isWeekend = IsWeekend(dayName);

            Console.WriteLine($"{dayName} является {(isWeekend ? "выходным" : "рабочим")} днем.");
        }
        else
        {
            Console.WriteLine("Некорректный номер дня недели.");
        }
    }

    static bool IsWeekend(string dayName)
    {
        List<string> weekendDays = new List<string>()
        {
            "Суббота",
            "Воскресенье"
        };

        return weekendDays.Contains(dayName);
    }
}
```

// Если число находится в словаре `daysOfWeek`, 
// мы получаем название дня и проверяем, является ли он выходным 
// с помощью метода `IsWeekend()`. 

// Метод `IsWeekend()` использует список `weekendDays`, 
// чтобы определить, является ли указанный день выходным.


