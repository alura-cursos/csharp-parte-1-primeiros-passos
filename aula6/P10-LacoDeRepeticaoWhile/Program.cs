using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_LacoDeRepeticaoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            int total = 0;

            while (contador <= 10)
            {
                total += contador;

                // contador = contador + 1;
                // contador += 1;
                contador++;
            }

            Console.WriteLine(total);

            Console.ReadLine();
        }
    }
}
