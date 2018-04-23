using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_LacoDeRepeticaoFor2
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int numero = 0; numero <= 10; numero++)
            {
                Console.Write("Tabuada do " + numero + " : ");

                for(int multiplicador = 1; multiplicador <= 10; multiplicador++)
                {
                    Console.Write(numero * multiplicador);
                    Console.Write(" ");
                }

                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
