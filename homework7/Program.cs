/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/


// matr.GetLength(0)- д
Random RND = new Random();
double[,] matrix = new double[3,4];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j]= Math.Round(RND.NextDouble(),1);
        Console.Write(matrix[i,j].ToString().Replace(",",".") + ",");
    }
    Console.WriteLine();
}    

/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
Console.WriteLine("Задача 50");
int[,] matrix2 = new int[3,4];
for (int i = 0; i < matrix2.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        matrix2[i,j]=RND.Next(0,9);
        Console.Write(matrix2[i,j]+ ",");
    }
    Console.WriteLine();
}
Console.Write("Введите два числа обозначающие позиции элементов(через запятую): ");
string line = Console.ReadLine();
int [] position = new int[2]{int.Parse(line.Split(",")[0]),int.Parse(line.Split(",")[1])};
if (position[0]<= matrix2.GetLength(0)-1 && position[1] <= matrix2.GetLength(1)-1 )//null- то, что несуществуют
{
    Console.WriteLine(matrix2[position[0],position[1]]);
}
else
{
    Console.WriteLine("Нет числа с такими индексами");
}