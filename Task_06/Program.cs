using System;

namespace Task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Да се напише програма, която преобразува десетично число в шестнадесетично.
            Console.Write("Enter decimal number: ");
            int deci = Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0} to hexadecimal is {1}.",
                deci, deci.ToString("X"));
        }
    }
}
