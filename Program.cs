using System;

namespace TestRepo
{
//Bad code for static analysis tests
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int i = 0;

            if (i == 0)
            {
                Console.WriteLine("Hello World!2");
            }
            else
            {
                Console.WriteLine("Hello World!2");
            }
 Console.WriteLine("Hello World!3");

        }
    }
}
