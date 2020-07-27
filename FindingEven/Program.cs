using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę: ");

            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number % 2 == 0)
                    Console.WriteLine("Podana liczba jest parzysta");

                else
                    Console.WriteLine("Podana liczba jest nieparzysta");
            }

            else
            {
                Console.WriteLine("Podana wartość jest nieprawidłowa.");
            }

            Console.ReadLine();

        }
    }
}
