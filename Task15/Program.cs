/*
Урок 2.Базовые алгоритмы

Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

//Console.WriteLine("Урок 2. Задача 15");

Console.WriteLine("Input number: ");

int A = int.Parse(Console.ReadLine());

Console.WriteLine(A);

if (A <= 5)
{
    Console.WriteLine("Это не выходной.");
}
else if (A >= 6 && A <= 7)
{
    Console.WriteLine("Ура выходной");
}
else
{
    Console.WriteLine("В недели только 7 дней !!!");
}
    