/*
 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
Console.WriteLine("Задача 41");
Console.WriteLine("Введите числа через запятую: ");
string[] Newmassiv = Console.ReadLine().Split(',');
int [] Massiv2 = new int [Newmassiv.Length];
for (int i = 0; i < Newmassiv.Length; i++)
{
  Massiv2[i] = int.Parse(Newmassiv[i]);
}
int count = 0;
for (int i = 0; i < Newmassiv.Length; i++)
{
    Console.Write(Massiv2[i]+ ",");
    if (Massiv2[i] > 0)
    {
        count++;
    }
}
Console.WriteLine("\n Результат: "+ count);

/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
Console.WriteLine("Задача 43");
Console.WriteLine("Введите b1 = ");
float b1 = float.Parse(Console.ReadLine()); // число с плавающей запятой 
Console.WriteLine("Введите k1 = ");
float k1 = float.Parse(Console.ReadLine());
Console.WriteLine("Введите b2 = ");
float b2 = float.Parse(Console.ReadLine());
Console.WriteLine("Введите k2 = ");
float k2 = float.Parse(Console.ReadLine());
double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;
x = Math.Round(x, 3); //Math.Round  -  округляет число до ближайшего целого
y = Math.Round(y, 3);
//float x = k1 * x + b1;
//float y = k2 * x + b2;
Console.WriteLine($"{x},{y}");


