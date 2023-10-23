using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] students = new string[3];
            //students[0] = "Engin";
            //students[1] = "Derin";
            //students[2] = "Salih";


            //string[] students2 =  {"Engin", "Derin", "Salih"};
            //students2[2] = "Ahmet";

            ////foreach (string s in students) {
            ////    Console.WriteLine(s);
            ////}

            //foreach (string s in students2)
            //{
            //    Console.WriteLine(s);
            //}

            string[,] regions = new string[5, 3] // satir(5) - sutun(3)
            {
                {"Istanbul", "Izmit", "Balikesir"},
                {"Ankara", "Konya", "Kirikkale"},
                {"Antalya", "Antalya", "Mersin"},
                {"Rize", "Trabzon", "Samsun"}, 
                {"Izmir", "Mugla", "Manisa"}, 
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++) //satir
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++) //sutun
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
