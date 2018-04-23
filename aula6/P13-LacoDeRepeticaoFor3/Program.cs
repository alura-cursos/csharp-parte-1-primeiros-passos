using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_LacoDeRepeticaoFor3
{
    class Program
    {
        static void Main(string[] args)
        {
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********

            for(int linha = 0; linha < 10; linha++)
            {
                for(int coluna = 0; coluna < 10; coluna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // *
            // **
            // ***
            // ****
            // *****
            // ******
            // *******
            // ********
            // *********
            // **********
            for(int linha = 0; linha < 10; linha++)
            {
                for(int coluna = 0; coluna < 10; coluna++)
                {
                    if (coluna > linha)
                        break;

                    Console.Write("*");
                }
                Console.WriteLine();
            }


            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna <= linha; coluna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
