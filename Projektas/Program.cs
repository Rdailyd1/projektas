using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas
{
    class Program
    {
        static void Main(string[] args)
        {
            double rutulio_plotas = 0;
            double rutulio_turis = 0;
            double izamb_ilgis = 0;

            double suma = rutulio_plotas + rutulio_turis + izamb_ilgis;
            double vidurkis = suma / 3;
            Console.WriteLine("Suma={0}", suma);
            Console.WriteLine("Vidurkis={0}", vidurkis);
        }
    }
}
