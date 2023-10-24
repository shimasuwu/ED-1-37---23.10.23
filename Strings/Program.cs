using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "Im Batman!";
            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "I believe i can flyyy";

            bool tf = sentence.EndsWith("y");

            var result3 = sentence.IndexOf("believe");
            var result4 = sentence.IndexOf(" ");
            var result5 = sentence.LastIndexOf(" "); //indexi aramaya cumlenin sonundan baslar.
            var result6 = sentence.Insert(0,"hiiii ");
            var result7 = sentence.Substring(4 ); //4.indexten itibaren al.
            var result8 = sentence.Replace("can","cant"); //4.indexten itibaren al.
            var result9 = sentence.ToUpper(); 
            var result10 = sentence.ToLower();
            var result11 = sentence.Remove(2,5); //2 den itibaren 5 karkateri ucurrr.



            Console.WriteLine(result2);
            Console.WriteLine(tf);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result6);
            Console.WriteLine(result7);
            Console.WriteLine(result8);
            Console.WriteLine(result9);
            Console.WriteLine(result10);
            Console.WriteLine(result11);

            Console.Read();
        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "Istanbul";
            string result = city + city2;
            Console.WriteLine(result); // AnkaraIstanbul

            Console.WriteLine(String.Format("{0} {1}", city, city2)); // 0 = ankara, 1= istanbul
            Console.WriteLine("{0}", city);
        }
    }
}
