using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Bitte, das Total des Einkaufs angeben: ");
            int total = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitte, den bezahlten Betrag angeben: ");
            int betrag = Convert.ToInt32(Console.ReadLine());
            int ruckkgeld;
            int differenz;

            if (betrag > total)
            {
                ruckgeld = betrag - total;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Rückgeld:{0}", rükgeld);
            }
            else
            {
                differenz = total - betrag;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Differenz:{0}", differenz);
            }
            Console.ResetColor();
                Console.ReadLine();
        }
    }
}
