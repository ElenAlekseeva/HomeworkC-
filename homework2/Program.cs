
/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.WriteLine("Задача 10");
Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());
char[] massiv = number.ToString().ToArray();
for (int i = 0; i < massiv.Length; i++) //massiv.Lenght- чисто элементов в массиве или его длина 
{
    if (i == 1)
        Console.WriteLine("Вторая цифра введеного трехзначного числа: " +  massiv[i]);
}

Console.WriteLine("Задача 13 ");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int numbers = int.Parse(Console.ReadLine());
string numbersText = Convert.ToString(numbers);
if (numbersText.Length > 2){
  Console.WriteLine("третья цифра -> " + numbersText[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Задача 15 ");

Console.Write("Введите цифру, обозначающую день недели: ");
int dayNumber = int.Parse(Console.ReadLine());

void DayWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("(этот день выходной) -> да");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine(" Введите число соответствующее дню недели от 1 до 7 ");
  }
  else Console.WriteLine("(этот день не является выходным) -> нет");
}

DayWeek(dayNumber);

