// start:

// Console.WriteLine("Чтобы выйти введите -1"); // эта строка для выхода из зацикленного действия
Console.Write("Введите число: ");
string stringNum = Console.ReadLine()??"0";
int num = Convert.ToInt32(stringNum);

if (num == -1) return; // если значение переменной "num" равно -1, 
// то функция прекращает свое выполнение и возвращает управление на вызывающий код.

if (stringNum.Length != 3) // если длина строки "stringNum" не равна 3, 
// то выполняется код внутри блока if.
    Console.WriteLine("Число не трёхзначное");
else
{
    Console.WriteLine((num / 100) * 10 + (num % 10));
}

// Console.WriteLine(stringNum.Length != 3 ? "Число не трёхзначное" : (num / 100) * 10 + (num % 10));

// Console.WriteLine();

// goto start; // оператор перехода goto использовался здесь для зацикленности действий
// но этот оператор НИКОГДА НЕ ИСПОЛЬЗОВАТЬ
// для зацикленности есть другие способы