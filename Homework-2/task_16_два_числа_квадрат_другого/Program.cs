﻿// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого. 
// 5, 25  ->  да-4, 
// 16  ->  да 25, 
// 5  ->  да 8,
// 9  ->  нет

int numA = int.Parse (Console.ReadLine()??"0");
int numB = int.Parse (Console.ReadLine()??"0");

bool test1 = (numA == numB*numB); // оператор сравнения `==` сравнивает значение numA с произведением numB на само себя
// результат - логическое значение `true` (истина), если равно
// `false` (ложь), если нет 
// итоговое значение `true` или `false` присваивается переменной `test1` типа `bool`, 
// которая является булевым типом данных
bool test2 = (numB == numA*numA);

if (test1) Console.WriteLine ("Первое число квадрат второго");
if (test2) Console.WriteLine ("Второе число квадрат первого");
if (!(test1||test2)) // если один из двух тестов верен, то тру
// логическое или || это значит либо одно либо другое
// а если оба не правильные, то следующее действие
// ! перед выражением означает отрицание этого выражения
// "если не выполняется условие, что test1 или test2 являются истинными", то выполняется следующее действие в скобках
{
    Console.WriteLine ("Числа не квадраты друг друга");
}