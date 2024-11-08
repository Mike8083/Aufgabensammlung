using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1: ");
            int zahl1 = int.Parse(Console.ReadLine());

            Console.Write("2: ");
            int zahl2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Summe: " + (zahl1 + zahl2)); // Verwendung von zahl1 und zahl2
            Console.ReadKey();
        }
    }
}
