using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte, Total des Einkaufs angeben: ");
            int summe = Convert.ToInt32(Console.ReadLine());
            int bezahlt = 0;

            while (bezahlt < summe
            {
                Console.Write("Bitte bezahlten Betrag angeben: ");
                int zahlung = Convert.ToInt32(Console.ReadLine());

                bezahlt += zahlung;

                if (bezahlt > summe)
                {
                    int ruckgeld = bezahlt - summe;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Rückgeld: {0}", ruckgeld);
                    break;
                }
                else if (bezahlt == summe)
                {
                    Console.WriteLine("Vielen Dank für Ihren Einkauf!");
                    break;
                }
                else
                {
                    int differenz = summe - bezahlt;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Differenz: {0}", differenz);
                
                }
                Console.ResetColor  ();
            }

            Console.ResetColor();
            Console.ReadLine();

        }
    }
}
