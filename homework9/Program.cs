/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
Console.WriteLine("Задача 64");
            Console.Write("Введите число N: ");
            int N = int.Parse(Console.ReadLine());
            
            Recurse(N);

            void Recurse(int n)
            {
                if (n > 0)
                {
                    Console.Write(n + " ");
                    Recurse(n - 1);
                }
            }




/*  Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
        M = 1; N = 15 -> 120
        M = 4; N = 8. -> 30
 */
            Console.WriteLine("Задача 64");
            Console.Write("Введите число M: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Введите число N: ");
            int n = int.Parse(Console.ReadLine());

            int Summ = 0;

            Summ = RecursedMethod(m, n, Summ);


            int RecursedMethod(int a, int b, int sum)
            {
                if (a <= b)
                {
                    Console.Write(a + " ");
                    sum = sum + a;
                    a++;
                    return RecursedMethod(a, b, sum);
                    
                }
                return sum;
            }

            Console.WriteLine("Сумма: " + Summ);

    /* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
		// m = 2, n = 3 -> A(m,n) = 29
        */

        Console.Write("Введите число M: ");
            int mm = int.Parse(Console.ReadLine());

            Console.Write("Введите число N: ");
            int nn = int.Parse(Console.ReadLine());
		int Akker(int m, int n)
		{
			if(m == 0)
			{
				return n + 1;
			}
			if(m > 0 && n == 0)
			{
				return Akker(m - 1, 1);
			}
			return Akker(m - 1, Akker(m, n - 1));
		}
		
		Console.WriteLine(Akker(nn,mm));
	
