using System;

namespace Task_03
{
    class Program
    {
        // Превърнете шестнайсетичните числа 2A3E, FA, FFFF, 5A0E9 в двоична и десетична бройна система.
        static void conversion(string value)
        {
            Console.WriteLine("{0} в десетична е {1}.",
                value, Convert.ToInt32(value, 16));
            Console.WriteLine("{0} в двоична е {1}.\n", value,
                Convert.ToString(Convert.ToInt32(value, 16), 2));
        }

        static void Main(string[] args)
        {
            conversion("2A3E");
            conversion("FA");
            conversion("FFFF");
            conversion("5A0E9");
        }
        
    }
}
