using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int prufung = 0;
            float note;
           float summe = 0;
            string result = "ja";
            float durchschnit;


            do
            {
                Console.Write("Bitte geben Sie die {0}. Note ein: ", prufung + 1);
                note = Convert.ToSingle(Console.ReadLine());   
                
                prufung++;   
                summe += note;
                durchschnit = summe /prufung;


                                Console.WriteLine("Das ergbit einen Notenschnitt von:{0}", durchschnit);
                                Console.WriteLine("Noch eine Note eingeben?(J/n)");
                                result = Console.ReadLine();
            }
            while (result == "Ja" || result == "ja" || result == "j");
            { Console.WriteLine("Vielen Dank!");}
            Console.ReadLine();
        }
    }
}
