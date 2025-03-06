using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] produtos = new string[6];
            int i;

            for(i=0; i<6; i++)
            {
                //registrar os produtos no array
                Console.WriteLine("Digite o nome do produto " + i + " :");
                produtos[i] = (Console.ReadLine());
            }

            for (i = 0; i < 6; i++)
            {
                //exibir todos os propdutos do array
                Console.WriteLine(produtos[i]);
            }

            /*quando se usa (Console.ReadLine());
            espera que a péssoa digite uma string,
            só quando quer int ou float que muda
            int.Parse(Console.ReadLine());
            float.Parse(Console.ReadLine());
            */
            Console.ReadLine();
        }
    }
}
