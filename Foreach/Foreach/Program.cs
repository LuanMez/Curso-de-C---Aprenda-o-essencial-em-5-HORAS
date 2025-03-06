using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] palavras = { "Luan", "Matheus", "Katia", "Programação"};
            //ela serve para percorrer um array inteiro.
            //palavras é a variavel que vai receber cada elementos
            //do array foreach
            foreach (string palavra in palavras)// Para cada palavra no array palavras repita o bloco de codigos
            {
                Console.WriteLine(palavra);//exibir cada elementos do array
            }
        }
    }
}
