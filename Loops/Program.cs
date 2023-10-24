using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //forDongusu();

            //whileDongusu();

            //int number = 10;
            //do
            //{
            //    Console.WriteLine(number);
            //    number--;
            //} while (number >= 11);

            string[] students = new string[3] { "engin", "derin", "salih" };
            foreach (string s in students)
            {
                Console.WriteLine(s);
            }


            Console.ReadLine();
        }

        private static void whileDongusu()
        {
            int number = 100;

            while (number >= 100)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Bitti!");
        }

        private static void forDongusu()
        {
            for (int i = 2; i <= 100; i = i + 2) //2-100 arasi sayilari cifter sekilde yazidan bir dongu.
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Bitti!");

        }
    }
}