using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Message test 1");
            int i = 0;
            while (i < 5) // am scazut numarul de iteratii
            {
                Console.WriteLine("Test {0}", i); // am modificat linia 13

                i++; 
            }

        }
    }
}
