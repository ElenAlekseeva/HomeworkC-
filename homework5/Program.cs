/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

*/
Console.WriteLine("Задача 34");
Random RND = new Random();
int[] CreateRandomArray (int size, int minValue, int MaxValue)
{

    int[] newArray = new int[size];// не понимаю что тут происходит и как заполнить массив именно трехзначными числами.
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = RND.Next(minValue,MaxValue);
        
    }
   return newArray;
} 
int[] array = CreateRandomArray(10,100,999);
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2 == 0)
    {
        count++;
    }
    Console.Write(array[i]+",");
}

Console.WriteLine(" \n Результат: " + count);

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
Console.WriteLine("Задача 36");
Random RND2 = new Random(); // RND2 - переменная- обьект ,которая имеет внутри функции.Может вызвать функцию Next, которая может генерировать случайные числа
/* при обьявлении метода или функции  и циклах ; не ставятся
тип название функции аргумент/аргументы 
//[модификаторы] тип_возвращаемого_значения название_метода ([параметры])
//
{
    // тело метода
}
Пример
модификаторы - public,internal,private
тип_возвращаемого_значения - int,int[],string,string[],char,char[]
*/

int[]CreateRandomArray2(int size)

{
    int[] array2 = new int [size];
    for (int i = 0; i < array2.Length; i++)
    {
        array2[i] = RND2.Next(0,100); 
    }
    return array2;
}
int[] array3 = CreateRandomArray2(4);
int summa = 0;
for (int i = 0; i < array3.Length; i++)
{
    Console.Write(array3[i]+ ",");
    if ((i%2) != 0) //     ! - значит "не" т.е. не равняется 0
    {
        
    }
    else
    {
        summa = summa + array3[i];
    }
}

Console.WriteLine("Результат: " + summa);

