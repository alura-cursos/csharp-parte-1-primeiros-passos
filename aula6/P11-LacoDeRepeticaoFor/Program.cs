using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_LacoDeRepeticaoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;

            for(int contador = 0; contador <= 10; contador++)
            {
                total += contador;
            }

            Console.WriteLine(total);

            Console.ReadLine();
        }
    }
}
