using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;
                int n1 = 3 + 4 * 2;
                int n2 = (3 + 4) * 2;
                int n3 = 17 % 3;
                double n4 = 10.0 / 8;

                Console.WriteLine(n1);
                Console.WriteLine(n2);
                Console.WriteLine(n3);
                Console.WriteLine(n4);

            }
        }
    }
}