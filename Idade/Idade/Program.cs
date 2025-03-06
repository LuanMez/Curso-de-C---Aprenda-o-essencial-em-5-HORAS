using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua idade");
            int idade = int.Parse(Console.ReadLine());//pega a entrada do usuario
            /* 
            Console.ReadLine pega string para converter
            int.Parse(Console.ReadLine()); Parse ele
            converte para int assim como float se fosse
            necessario
            */

            if(idade<=2)
            {
                Console.WriteLine("Você é um bebê");
            }
            else if(idade>2 && idade<=12)
            {
                Console.WriteLine("Você é uma criança");
            } 
            else if(idade>12 && idade<=17)
            {
                Console.WriteLine("Você é um adolescente");
            } 
            else if(idade>17 && idade<=59)
            {
                Console.WriteLine("Você é um Adulto");
            }
            else
            {
                Console.WriteLine("Você é um idoso");
            }



                Console.ReadLine();

        }
    }
}
