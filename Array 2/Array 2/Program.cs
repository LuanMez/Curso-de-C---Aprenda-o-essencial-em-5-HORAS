using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            //Armazenando os produtos de forma manual com array fixo
            string[] produtos = new string[5]
            {
                "bola","mesa","cadeira","tesoura","sofa"
            };

            Console.WriteLine(produtos[0]);
            Console.WriteLine(produtos[1]);
            Console.WriteLine(produtos[2]);
            Console.WriteLine(produtos[3]);
            Console.WriteLine(produtos[4]);

            //trocar nome do produtos 3
            Console.WriteLine("Digite o novo produto 3: ");
            produtos[2] = Console.ReadLine();

            Console.WriteLine(produtos[0]);
            Console.WriteLine(produtos[1]);
            Console.WriteLine(produtos[2]);
            Console.WriteLine(produtos[3]);
            Console.WriteLine(produtos[4]);

            int[] valores = { 10, 20, 30, 40, 50 };

            for(i=0; i<5; i++)
            {
                Console.Write(valores[i] + " ");
            }

            Console.ReadLine();


        }
    }
}
