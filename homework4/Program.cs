/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
Console.WriteLine("Задача 25");
Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
int result = numberA;
int count = 1;
while (count < numberB)
{
   result = result * numberA;
   count ++;
}
Console.WriteLine("Результат: "+(result));

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.WriteLine(" Задача 27");
Console.Write("Введите число: ");
int numb = int.Parse(Console.ReadLine());
int summa = 0;
char [] numbers = numb.ToString().ToArray();
for (int i = 0; i < numbers.Length; i++)
{
   summa += int.Parse(numbers[i].ToString());
}
Console.WriteLine("Результат: " +summa);

/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
Console.WriteLine(" Задача 29");
Console.Write("Введите 8 чисел через запятую: ");
string[] massiv = Console.ReadLine().Split(',');
Console.Write("Результат: [ ");
for (int i = 0; i < massiv.Length; i++)
{
   Console.Write( massiv[i]+',');
}
Console.Write("]");
