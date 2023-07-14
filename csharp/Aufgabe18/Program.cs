using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte Startbuchstabe eingeben: ");
            char erstebuch = Console.ReadKey().KeyChar;
            Console.WriteLine();

        
            

            Console.Write("Bitte Endbuchstabe eingeben: ");
            char zweitebuch = Console.ReadKey().KeyChar;
            Console.WriteLine();

           

            // İlk harfle ikinci harf arasındaki harfleri yazdırma
            for (char buch = erstebuch; buch <= zweitebuch;buch++)
            {
                Console.Write(buch + "");
            }

            Console.ReadLine();
        }
    }
}
