using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string startBuchstabe, endBuchstabe;
            int startZahl, endZahl;

            do
            {
                Console.Write("Bitte Startbuchstabe eingeben: ");
                startBuchstabe = Console.ReadLine();
                Console.Write("Bitte Endbuchstabe eingeben: ");
                endBuchstabe = Console.ReadLine();

                if (string.IsNullOrEmpty(startBuchstabe) || string.IsNullOrEmpty(endBuchstabe))
                {
                    Console.WriteLine("Bitte beide Eingaben machen!");
                    continue;
                }

                if (startBuchstabe.Length > 1 || endBuchstabe.Length > 1)
                {
                    Console.WriteLine("Die Eingabe darf nur ein Zeichen enthalten!");
                    continue;
                }

                if (string.Compare(startBuchstabe, endBuchstabe) >= 0)
                {
                    Console.WriteLine("Der erste Buchstabe muss vor dem zweiten liegen im Alphabet!");
                    continue;
                }

                break;
            } while (true);

            startZahl = (int)startBuchstabe[0];
            endZahl = (int)endBuchstabe[0];

            for (int i = startZahl; i <= endZahl; i++)
            {
                Console.Write((char)i);
            }

            Console.ReadLine();

        }
    }
}
