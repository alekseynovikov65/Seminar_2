﻿/*
Урок 2.Базовые алгоритмы

Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.WriteLine("Урок 2. Задача 13");

//Считываем число
//проверяешь что длина строки больше или равна 3
//Если длина больше или равна 3, то считываешь третий символ: str[2]
//записываем третий символ в переменную
//выыводим переменную на экран
//Если длина меньше 3, то выводим на экран "Третьей цифры нет"
//Для считывание ввода используем команду Console.ReadLine()
//Для вывода используем команду Console.WriteLine()

Console.WriteLine("Input number: ");
string num = Console.ReadLine();
//int number = int.Parse(Console.ReadLine());
if (num.Length > 2)
{
    //string num = Console.ReadLine(number);
    Console.WriteLine(num[2]);
    ;
}
else
{
    Console.WriteLine($"Сказали же трехзначное");
}

