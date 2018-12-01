using System;

namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Да се напише програма, която преобразува двоично число в десетично.

            Console.Write("Въведeте двоично число: ");
            string binary = Console.ReadLine();
            Console.WriteLine("{0} в десетична е {1}.",
                binary, Convert.ToInt64(binary, 2));
        }
    }
}
