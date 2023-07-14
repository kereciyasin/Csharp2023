using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubung1._6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen bir Hece giriniz");
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
