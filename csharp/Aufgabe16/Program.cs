using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Bitte Anzahl der Bauklötze eingeben: ");
            int bauk = Convert.ToInt32(Console.ReadLine());
            int seiten = 1;

            while (bauk >= seiten * seiten)
            {
                Console.WriteLine("{0} Bauklötze reichen für ein Quadrat mit Seitenlänge {1}",bauk,seiten );
                seiten++;
                
            }
            Console.ReadLine();
        }
       
        
        
    }
}
