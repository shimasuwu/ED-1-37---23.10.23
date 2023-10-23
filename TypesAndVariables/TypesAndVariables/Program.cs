using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            int number1 = 2147483647; //32 bit, limit 2147483647;
            long number2 = 2147483647999; //64 bit
            short number3 = 32767; //16 bit
            byte number4 = 0; // 0-255, (-) deger alamaz.
            bool tf = false; //true ya da false
            char chrc = 'A'; // tek harf alir.
            double number5 = 36.5;
            decimal number6 = 23; //ondalikli da alabilir.
            


            Console.WriteLine("number1 is {0} ", number1);
            Console.WriteLine("number2 is {0} ", number2);
            Console.WriteLine("number3 is {0} ", number3);
            Console.WriteLine("number3 is {0} ", number4);
            Console.WriteLine("tf is {0} ", tf);
            Console.WriteLine("char is {0} ", chrc);
            Console.WriteLine("number5 is {0} ", number5);
            Console.WriteLine("number6 is {0} ", number6);
            Console.WriteLine("the index of the value 'saturday' in the enum is: {0} ", (int)Days.Saturday); //5

            Console.ReadLine();
        }

        enum Days { 
            Monday, Tuesday, Wednesday, Thusday, Friday, Saturday, Sunday
        }
    }
}
