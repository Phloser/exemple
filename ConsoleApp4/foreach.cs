using System;

namespace numb_Of_numb
{
    class @foreach
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            string a = Console.ReadLine();
            int count = 0;
            int z = 0;
            foreach(char symbol in a)
            {

                z = int.Parse(a);
                z = z-1;
                Console.WriteLine(z);
                count++;
            }
            Console.WriteLine($"number vol is {count}");
        }
    }
}
