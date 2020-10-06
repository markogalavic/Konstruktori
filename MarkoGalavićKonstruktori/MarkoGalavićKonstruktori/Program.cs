using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkoGalavićKonstruktori
{
    class Program
    {
        static void Main(string[] args)
        {
            PrvaKlasa x = new PrvaKlasa("Perica","Peric");
            Console.WriteLine(x.ToString());

            PrvaKlasa y = new PrvaKlasa("Ivan","Ivankovic");
            Console.WriteLine(x.ToString());

            PrvaKlasa z = new PrvaKlasa("Ivana","Janic");
            Console.WriteLine(x.ToString());

            Console.WriteLine(z.ToString());
            Console.ReadKey();
        }
    }
}
