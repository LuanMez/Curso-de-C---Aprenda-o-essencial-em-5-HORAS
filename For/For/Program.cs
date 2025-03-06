using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class Program
    {
        static int Tres = 3; //pode ser usado em qualquer função 
        const int Tress = 3; //pode ser usado em qualquer função 

        static void Main(string[] args)
        {

            string[] palavras = { "Amendoim", "Rato", "Selva" };
            for(int contador = 0; contador <= 10; contador++)
            {
                Console.WriteLine("Esse codigo está rodando " + contador + " vezes.");
            }


            //poderia por cont < 3 porque o array tem 3 posições
            for (int cont = 0; cont < palavras.Length; cont++)
            {
                Console.WriteLine(palavras[cont]);
            }

            /*for (int cont = 0; cont <= 3; cont++)
            {
                Console.WriteLine(palavras[cont]);
            }*/

            for (int cont2 = 2; cont2 >= 0; cont2--)
            {
                Console.WriteLine(palavras[cont2]);
            }
            //palavras.Length-1 porque ele da o tamanho que é 3
            for (int cont3 = palavras.Length-1; cont3 >= 0; cont3--)
            {
                Console.WriteLine(palavras[cont3]);
            }


            Console.ReadLine();
        }
    }
}
