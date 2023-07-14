using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Aufgabe17._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float note = 0;
            float durschnitt;
            float punkt;
            string result = "ja";
            float summe;

            do
            {
                Console.WriteLine("Bitte geben Sie die {0}. Note ein: ", note + 1);
               punkt = Convert.ToSingle(Console.ReadLine());

                summe = summe + punkt;
                durschnitt = summe / note;
                note++;
                Console.WriteLine("Das ergbit einen Notenschnitt von:{0}", durschnitt);
                Console.WriteLine("Noch eine Note eingeben?(J/n)");
                result = Console.ReadLine();
            }
            while (result == "Ja" || result == "ja" || result == "j");
            { Console.WriteLine("Vielen Dank!"); }
            Console.ReadLine();
        }
    }
}
