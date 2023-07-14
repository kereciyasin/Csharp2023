using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übung1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte Zahl eingeben");
            int zahl = Convert.ToInt32(Console.ReadLine());

            if (zahl % 2 == 0)
            {
                Console.WriteLine("True");
            }
            else { Console.WriteLine("False"); }
            Console.ReadLine(); 
        }
    }
}
