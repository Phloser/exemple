using System;

namespace ConsoleApp3
{
    class summNumb
    {
        static void PrintNumber(int a, int b)
        {
            if (a <= b)
            {
                Console.WriteLine(a);
                a++;
                PrintNumber(a, b);
            }
        }

        static int SumNumber(int a, int b)
        {
            if (a <= b)
            {
                var sum = SumNumber(a + 1, b);
                return a + sum;
            }
            return 0;
        }

        static void Main()
        {
            Console.Write("Введите число a: ");

            var aInput = Console.ReadLine();
            var d = Convert.ToInt32(aInput);
            Console.Write("Введите число b: ");
            var bInput = Console.ReadLine();
            var e = Convert.ToInt32(bInput);

            PrintNumber(d, e);
            Console.Write($"\nСумма всех чисел равна: { SumNumber(d, e)}");

            Console.ReadKey();
        }
    }
}
