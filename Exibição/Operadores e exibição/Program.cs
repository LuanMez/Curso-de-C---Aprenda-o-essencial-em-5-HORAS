using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_e_exibição
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";

            Console.WriteLine("Escreva seu nome:");
            nome = Console.ReadLine();

            /*
             Ou pode ser escrito assim sem declarar string vazia

            Console.WriteLine("Escreva seu nome:");
            string nome = Console.ReadLine();
             */

            Console.WriteLine("Seu nome é: ");
            Console.WriteLine(nome);


            Console.ReadLine();
        }
    }
}
