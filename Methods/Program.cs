using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //Console.W
            //riteLine(Add2(5));

            //int num1 = 20;
            //int num2 = 100;
            //var result = Add3(out num1, num2);
            //Console.WriteLine(result);
            //Console.WriteLine(num1);

            //Console.WriteLine(Multiply(2,4));
            //Console.WriteLine(Multiply(2, 4,6));

            Console.WriteLine(Add4(2, 4, 6,2,10)); //metodun params keywordu ile sinirsiz miktarda arguman girilebiliyor.


            Console.ReadLine();
        }

        static void Add() {
            Console.WriteLine("Added.");
        }

        static int Add2(int num1, int num2 = 30) {
            int result = num1 + num2;
            return result;
        }

        static int Add3(out int num1, int num2) {
            num1 = 30;
            return num1 + num2;
        }

        static int Multiply(int num1, int num2) {
            return num1 * num2;
        }

        static int Multiply(int num1, int num2, int  num3)
        {
            return num1 * num2 * num3;
        }

        static int Add4(params int[] num) { //params keyword'u ile num parametresine disaridan sinirsiz arguman alabilir.
            return num.Sum();
        }
    }
}
