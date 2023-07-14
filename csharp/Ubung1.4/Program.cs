using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubung1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte eine Zeichenkette angeben");
            string name = Console.ReadLine();   
             
            for (int i = 0; i < name.Length; i++) 
            
            {
            char c = name[i];
                Console.WriteLine(c);

            
            }

            Console.ReadLine();

        }
    }
}
