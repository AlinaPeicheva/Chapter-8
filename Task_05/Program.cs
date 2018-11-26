using System;

namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Да се напише програма, която преобразува двоично число в десетично.
            Console.Write("Enter binary number: ");
            string binary = Console.ReadLine();
            Console.WriteLine("{0} to decimal is {1}.",
                binary, Convert.ToInt64(binary, 2));
        }
    }
}
