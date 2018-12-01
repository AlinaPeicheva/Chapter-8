using System;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Да се напише програма, която преобразува десетично число в двоично.

            Console.Write("Въведeте число: ");
            int n = Int32.Parse(Console.ReadLine());
            string binary = Convert.ToString(n, 2);
            Console.WriteLine("Резултата е {0}", binary);
        }
    }
}
