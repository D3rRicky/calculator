using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl1;
            int zahl2;
            String eingabe;

            Console.WriteLine("This is the programm: Taschenrechner");
            Console.WriteLine("Version: 1.0");
            Console.WriteLine("Language: German");
            Console.WriteLine("Creator: DerRicky");
            Console.WriteLine();
            Console.WriteLine("Bitte geben sie die erste Zahl ein:");
            zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bitte geben sie die zweite Zahl ein:");
            zahl2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bitte geben sie ein, was mit den zwei zahlen gemacht werden soll!");
            Console.WriteLine("Aktionen: [ + | - | * | / ]");
            eingabe = Console.ReadLine();

            if (eingabe == "+")
            {
                Console.WriteLine(zahl1 + " + " + zahl2 + " = " + (zahl1 + zahl2));
                Console.ReadKey();
            }

            else if (eingabe == "-")
            {
                Console.WriteLine(zahl1 + " - " + zahl2 + " = " + (zahl1 - zahl2));
                Console.ReadKey();
            }

            else if (eingabe == "*")
            {
                Console.WriteLine(zahl1 + " * " + zahl2 + " = " + (zahl1 * zahl2));
                Console.ReadKey();
            }

            else if (eingabe == "/")
            {
                Console.WriteLine(zahl1 + " / " + zahl2 + " = " + (zahl1 / zahl2));
                Console.ReadKey();
            }
        }
    }
}
