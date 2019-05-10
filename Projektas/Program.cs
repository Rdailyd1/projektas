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
            double rutulio_plotas = 4 * Math.PI * 6371*6371);
            double rutulio_turis = 4/3 * Math.PI* 6371*6371*6371;
            double izamb_ilgis = 10 * 10 * 15 * 15;

            double suma = rutulio_plotas + rutulio_turis + izamb_ilgis;
            double vidurkis = suma / 3;
            Console.WriteLine("Suma={0}", suma);
            Console.WriteLine("Vidurkis={0}", vidurkis);
        }
    }
}
