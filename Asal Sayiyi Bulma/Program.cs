using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Asal_Sayiyi_Bulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (IsPrimeNumber(6))
            {
                Console.WriteLine("This is optimus prime");
            }
            else { 
                Console.WriteLine("this is not a prime number");
            }

            Console.Read();

        }
        private static bool IsPrimeNumber(int number) {

            bool result = true;
            for (int i = 2; i < number-1 ; i++)
            {
                if (number %2 == 0)
                {
                    result = false;
                }
            }
            return result;
        
        }
    }
}
