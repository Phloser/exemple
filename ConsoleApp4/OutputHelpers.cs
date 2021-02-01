using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class OutputHelpers
    {
        public static void PrintInCenter(string text)
        {
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.WindowHeight / 2 - 1);
            Console.WriteLine(text);
        }

        public static void Pause()
        {
            Console.ReadKey();
        }
    }
}
