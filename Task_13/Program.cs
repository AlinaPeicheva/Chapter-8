using System;

namespace Task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Да се напише програма, която по зададени N, S, D (2 ≤ S, 16 ≥ D) преобразува числото N от бройна система с основа S към бройна система с основа D.
            /* 1. Вводим число N и после задаём ему основу(например число 101 с основой 2)
               2. Вводим основу первого числа S (в скобках указаны основы из которых нужно выбрать нужную)
               3. Вводим D основу числа, которое хотим получить (в скобках указаны основы из которых нужно выбрать нужную) */
            int s, d;
            
            Console.Write("Въведите N: ");
            string n = Console.ReadLine();

            do
            {
                Console.Write("Въведите S (S == 2, 8, 10 or 16): ");
                s = Int32.Parse(Console.ReadLine());
            } while (s != 2 && s != 8 && s != 10 && s != 16);

            do
            {
                Console.Write("Въведите D (D == 2, 8, 10 or 16): ");
                d = Int32.Parse(Console.ReadLine());
            } while (d != 2 && d != 8 && d != 10 && d != 16);

            n = Convert.ToString(Convert.ToInt32(n, s), d);

            Console.WriteLine("Резултата е {0}.", n);
        }
    }
}
