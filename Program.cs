using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Ponavljanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj članova reda:");
            double suma = 0;
            double brojClanova = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < brojClanova; i++)
            {
                suma += 1 / Math.Pow(3, i + 1);
            }

            Console.WriteLine("Suma reda je: " + suma);
            Console.ReadLine();

        }
    }
}
