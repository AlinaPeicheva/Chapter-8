using System;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Превърнете числото 1111010110011110(2) в шестнадесетична и в десетична бройна система.

            Console.WriteLine("1111010110011110 в десетична е {0}.",
            Convert.ToInt64("1111010110011110", 2));

            Console.WriteLine("1111010110011110 в шестнадесетична е {0}.",
            Convert.ToInt64("1111010110011110", 2).ToString("X"));
        }
    }
}
