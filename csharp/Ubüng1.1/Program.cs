using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ubüng1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float gesamtpunktzahl = 0;
            int notSayisi = 0;
            string cevap = "J";

            while (cevap == "J" || cevap == "j")
            {
                Console.Write("Bitte geben Sie die {0}. Note ein: ", notSayisi + 1);
                float note = Convert.ToSingle(Console.ReadLine());
                gesamtpunktzahl += note;
                notSayisi++;

                float notenschnitt = gesamtpunktzahl / notSayisi;
                Console.WriteLine("Das ergibt einen Notenschnitt von: {0}", notenschnitt);

                Console.Write("Noch eine Note eingeben? (J/n): ");
                cevap = Console.ReadLine();
            }

            Console.WriteLine("Vielen Dank!");
            Console.ReadLine();
        }


    }
}