using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pripramaZaIspit5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst;

            Console.WriteLine("Unesite neki tekst: ");
            
            tekst = Console.ReadLine();

            Console.WriteLine(tekst.Substring(2) + tekst.Substring(0, tekst.Length -2));

            if(tekst.Length < 5)
            {
                Console.WriteLine(tekst);
            }

            Console.ReadLine();
        }
    }
}
