// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Задача 2");

/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
//Console.WriteLine("введите а: ");
int a = 5;
//Console.WriteLine("введите b: ");
int b = 7;
if (a>b)
{
    Console.WriteLine("Результат: a большее");
    
}
else if (a<b)
{
    Console.WriteLine("Результат: b большее ");

}

Console.WriteLine("Задача 4");

/*
 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
int a_1 = 2;
int a_2 = 3;
int a_3 = 7;
if(a_1 > a_2 && a_2 > a_3)
    Console.WriteLine(" max = " + a_1);
else if (a_2 > a_1 && a_2 > a_3)
    Console.WriteLine(" max = " + a_2);
else if (a_3 > a_1 && a_3 > a_2)
    Console.WriteLine(" max = " + a_3);


Console.WriteLine("Задача 6");

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
if ((number1 % 2) == 0)
Console.WriteLine("Число четное");
else
Console.WriteLine("Число нечетное");

Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if ((number2 % 2) == 0)
Console.WriteLine("Число четное");
else
Console.WriteLine("Число нечетное");

Console.WriteLine("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine());
if ((number3 % 2) == 0)
Console.WriteLine("Число четное");
else
Console.WriteLine("Число нечетное");

