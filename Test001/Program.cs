using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//** Umrechnung zwischen verschiedenen Zahlensystemen
namespace Test001
{
    class Program
    {
        static void Main(string[] args)
        {
            Titel("Dies ist ein Test");
            Console.ReadKey();
        }
        /// <summary>
        /// Zeigt einen Titel an
        /// </summary>
        /// <param name="titel">Inhalt des Titels</param>
        static void Titel(string titel)
        {
            Console.Clear();
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("-");
            }
            //*** Hier fehlt das Zentrieren
            Console.WriteLine(titel);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("-");
            }

        }

    }
}
