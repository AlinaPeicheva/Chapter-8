using System;

namespace Task_07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Да се напише програма, която преобразува шестнадесетично число в десетично.

            Console.Write("Въведeте шестнадесетично число: ");
            string hexa = Console.ReadLine();
            Console.WriteLine("{0} в десетична е {1}.",
                hexa, Convert.ToInt32(hexa, 16));
        }
    }
}
