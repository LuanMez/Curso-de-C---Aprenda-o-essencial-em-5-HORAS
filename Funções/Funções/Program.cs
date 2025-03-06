using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funções
{
    class Program
    {
        static void Main(string[] args)
        {
            exibirMsg();

            Console.WriteLine("Digite o seu preco");
            int preco = int.Parse(Console.ReadLine());

            gerarPreco(preco);

            Console.ReadLine();
        }

        static void exibirMsg()
        {
            Console.WriteLine("Esse sistema é show de bola!");
            Console.WriteLine("Estou usando função");
        }

        static void gerarPreco(int preco)
        {
            if (preco < 0)
            {
                //concatenação somando dois textos
                Console.WriteLine("Seu preco é negativo??? " + preco);
                int precoAbs = Math.Abs(preco); //Math.Abs converte número negativo para positivo
                Console.WriteLine("Agora está correto " + precoAbs);
            } 
            else
            {
                Console.WriteLine("Seu preco é positivo!!! " + preco);
            }
        }
    }
}
