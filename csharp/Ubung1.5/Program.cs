using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubung1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir harf girin");
            string name = Console.ReadLine();   
            Console.WriteLine("Lütfen tekrar sayisini girin");
            int repat = Convert.ToInt32(Console.ReadLine());

            string ausgabe = "";

           for (int i = 0; i < repat; i++)
            {

                ausgabe = ausgabe + name;
            }
            Console.WriteLine(ausgabe);
            Console.ReadLine(); 
        }
    }
}
