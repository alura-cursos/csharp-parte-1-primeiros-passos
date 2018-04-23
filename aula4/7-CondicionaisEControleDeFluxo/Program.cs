using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_CondicionaisEControleDeFluxo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7");

            int idade = 15;
            int numeroPessoas = 2;

            if (idade >= 16)
            {
                Console.WriteLine("Bem-vindo, você pode entrar!");
            }
            else if (numeroPessoas >= 2)
            {
                Console.WriteLine("Você não tem 16 ou mais de idade, mas está acompanhado. Pode entrar!");
            }
            else
            {
                Console.WriteLine("Infelizmente você não pode entrar pois não tem 16 e não está acompanhado");
            }

            Console.ReadLine();
        }
    }
}
