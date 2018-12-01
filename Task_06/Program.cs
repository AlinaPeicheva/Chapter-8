using System;

namespace Task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Да се напише програма, която преобразува десетично число в шестнадесетично.
            Console.Write("Въведите десетично число: ");
            int deci = Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0} в шестнадесетична е {1}.",
                deci, deci.ToString("X"));
        }
    }
}
