using System;

namespace Task_09
{
    class Program
    {
        static void Main(string[] args)
        {
            // Да се напише програма, която преобразува двоично число в шестнадесетично.
            Console.Write("Enter binary number: ");
            string binary = Console.ReadLine();
            Console.WriteLine("{0} to hexadecimal is {1}.",
                binary, Convert.ToInt32(binary, 2).ToString("X"));
        }
    }
}
