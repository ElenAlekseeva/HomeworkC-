/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
using System;

Console.WriteLine("Задача 19");
Console.WriteLine("Введите пятизначное число");
int number19 = int.Parse(Console.ReadLine());
string numberstring = number19.ToString();
char[] massiv = numberstring.ToArray();
/* тип int/string/char название = действия 
char - символ 
char x = 'x';
char star = '*';
char five = '55'; 
char dollar = '$';
*/
char[] massiv2 = numberstring.ToArray();
massiv2 = Enumerable.Reverse(massiv).ToArray();
int sovpadenia = 0;
for (int i = 0; i < massiv.Length; i++)
{
    if (massiv[i] == massiv2[i])
    {
        sovpadenia++;
    }
}
if (sovpadenia == 5)
    Console.WriteLine("число является палиндромом");
else
    Console.WriteLine("число не является палиндромом");

 

Console.WriteLine("Задача 21");
/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.WriteLine("Введите координаты первой точки через запятую: ");
string[] astring = Console.ReadLine().Split(',');   //3,4,5
Console.WriteLine("Введите координаты второй точки через запятую: ");
string[] bstring = Console.ReadLine().Split(',');
double[] a = { Double.Parse(astring[0]), Double.Parse(astring[1]), Double.Parse(astring[2]) };
double[] b = { Double.Parse(bstring[0]), Double.Parse(bstring[1]), Double.Parse(bstring[2]) };
    // x  y  z
//double[] a = { 3, 6, 8 };
//double[] b = { 2, 1, -7 };

double result = Math.Sqrt(Math.Pow((b[0] - a[0]), 2) + Math.Pow((b[1] - a[1]), 2) + Math.Pow((b[2] - a[2]), 2));


Console.WriteLine("Результат: " + result);


/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
for (int i = 1; i < number + 1; i++)
{
    int res = i * i * i;
    Console.WriteLine($"Результат:{res}");
}
