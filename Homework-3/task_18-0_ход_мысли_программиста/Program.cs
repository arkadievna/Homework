﻿// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// примерный ход мысли программиста:

// 1) ввести номер четверти - метод ReadData()

// 2) ответить на вопрос 
// ---основная задача метода---
// -> внутрь поступит номер четверти интеджер int ->
// -> на выходе должен ответ появится в формате string
// имя метода QuterBorderAsk
string QuterBorderAsk(int numQut)
{
    if (numQut == 1) return "x>0, y>0"; // "" - эти кавычки указание, что это строка string
    if (numQut == 2) return "x>0, y<0";
    if (numQut == 3) return "x<0, y<0";
    if (numQut == 4) return "x<0, y>0";

    return string.Empty;
}

// 3) вывести ответ - метод PrintResult()



