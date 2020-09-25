using System;

namespace While_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var a = 1;
            while (a < 26) {
                var cubed = a * a * a;
                Console.WriteLine($"{a} cubed {cubed}");
                //a++;


            }
            
        }
    }
}
