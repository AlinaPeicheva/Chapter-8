using System;

namespace Task_08
{
    class Program
    {
        static void Main(string[] args)
        {
            // Да се напише програма, която преобразува шестнадесетично число в двоично.

            Console.Write("Въведeте шестнадесетично число : ");
            string hexa = Console.ReadLine();
            Console.WriteLine("{0} в двоична е {1}.",
                hexa, Convert.ToString(Convert.ToInt32(hexa, 16), 2));
        }
    }
}
