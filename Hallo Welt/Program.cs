using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hallo_Welt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte gib deinen Namen ein");

            string eingabeVomBenutzer = Console.ReadLine();

            Console.WriteLine("Hallo " + eingabeVomBenutzer);

            Console.ReadKey();
        }
    }
}
