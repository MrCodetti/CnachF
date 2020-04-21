using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tempBerechnung;

namespace CnachF
{
    class Program
    {
        static void Main(string[] args)
        {
            int wahl = 0;
            int celsius, fahrenheit;

            Console.WriteLine("Auswahl Konvertierungstyp");
            Console.WriteLine("1. Celsius --> Fahrenheit");
            Console.WriteLine("2. Fahrenheit --> Celsius");
            string input = Console.ReadLine();

            if (int.TryParse(input, out wahl))
            {
                switch (wahl)
                {
                    case 1:
                        Console.WriteLine("Celsius wert: ");
                        celsius = int.Parse(Console.ReadLine());
                        Console.WriteLine(Berechnung.CnachF(celsius));
                        break;
                    case 2:
                        Console.WriteLine("Fahrenheit wert: ");
                        fahrenheit = int.Parse(Console.ReadLine());
                        Console.WriteLine(Berechnung.FnachC(fahrenheit));
                        break;
                }
            }
            else
            {
                Console.WriteLine("Syntax Error");
            }
            Console.ReadKey();


        }
    }
}
