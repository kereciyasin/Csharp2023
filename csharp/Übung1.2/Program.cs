using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übung1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayi giriniz");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayi giriniz");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen ücüncü sayi giriniz");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                if (a > b)
                { Console.WriteLine(a); }
                else { Console.WriteLine(c); }

            }

            else
            {
                if (b > c)
                {
                    Console.WriteLine(b);
                }
                else
                {
                    Console.WriteLine(c);
                }
                Console.ReadLine();
            }
        }
    }
}
