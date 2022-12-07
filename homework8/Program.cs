/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
Random RND = new Random();
Console.WriteLine("Задача 56"); 
int[,] matrix = new int[4,4];
 
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j]= RND.Next(0,9);
        Console.Write(matrix[i,j].ToString());
    }
    Console.WriteLine();
}
int [] summ = new int[4];
int min = 1000;
int line = 0;
for (int i = 0; i < matrix.GetLength(0); i++) //строки
{
    int localsumm = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)//столбцы
    {
        localsumm +=  matrix[i,j];// += то же самое что localsumm = localsumm + matrix[i,j]
    }
    summ[i] = localsumm; 
    Console.WriteLine($"Сумма {i} строки: {summ[i]}");
    if (localsumm < min)
    {
        min= localsumm;
        line= i;
    }
}
Console.WriteLine("Строка с наименьшей суммой элементов: "+line);
/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по
 убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
int[,] matrix2 = new int[4,4];
for (int i = 0; i < matrix2.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        matrix2[i,j] = RND.Next(0,9);
        Console.Write(matrix2[i,j].ToString() + " ");
          }
          Console.WriteLine();
} 
 /*
 Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
Console.WriteLine("Задача 60");
bool checkrepeat(int[,,]matrix,int number)
{
  for (int  i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int n = 0; n < matrix.GetLength(2); n++)
        {
            if (matrix[i,j,n]== number)
            {
                return true;
            }
           
        }
       
    }
    

}
return false;
}
int[,,] matrix3 = new int[2,2,2];
for (int  i = 0; i < matrix3.GetLength(0); i++)
{
    for (int j = 0; j < matrix3.GetLength(1); j++)
    {
        for (int n = 0; n < matrix3.GetLength(2); n++)
        {
            tryagain:
            int rnd= RND.Next(10,99);

            bool hasRepeat=checkrepeat(matrix3,rnd);
            if (hasRepeat)
            {
                goto tryagain;
            }
                matrix3[i,j,n] = RND.Next(10,99);
         
            
            Console.Write(matrix3[i,j,n].ToString()+ $"({i},{j},{n}) ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

}

