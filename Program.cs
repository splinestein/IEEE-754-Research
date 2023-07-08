using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
                Converstion will happen later. 
                Datatype has to be string because leading 0's would otherwise be ignored.
                Adding length check and 0 || 1 only int verification later.
            */

            Console.WriteLine("(binary64) Set sign: 1 bit.");
            string sign = Console.ReadLine();

            Console.WriteLine("(binary64) Set exponent, 8 bits.");
            string exponent = Console.ReadLine();

            Console.WriteLine("(binary64) Set mantissa / fraction, 52 bits.");
            string mantissa = Console.ReadLine();

            Console.WriteLine($"{sign} {exponent} {mantissa}");
        }
    }
}
