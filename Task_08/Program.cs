using System;

namespace Task_08
{
    class Program
    {
        static void Main(string[] args)
        {
            // Да се напише програма, която преобразува шестнадесетично число в двоично.
            Console.Write("Enter hexadecimal number: ");
            string hexa = Console.ReadLine();
            Console.WriteLine("{0} to binary is {1}.",
                hexa, Convert.ToString(Convert.ToInt32(hexa, 16), 2));
        }
    }
}
