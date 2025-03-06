using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração das variaveis
            int num, cond=0;

            while (cond == 0)
            {
                Console.WriteLine("Digite um numero de 1 a 5");
                num = int.Parse(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        Console.WriteLine("Você digitou 1");
                        cond = 1;
                        break;
                    case 2:
                        Console.WriteLine("Você digitou 2");
                        cond = 1;
                        break;
                    case 3:
                        Console.WriteLine("Você digitou 3");
                        cond = 1;
                        break;
                    case 4:
                        Console.WriteLine("Você digitou 4");
                        cond = 1;
                        break;
                    case 5:
                        Console.WriteLine("Você digitou 5");
                        cond = 1;
                        break;
                    default:
                        Console.WriteLine("Voce digitou um número invalido");
                        break;
                }
            }

            Console.ReadLine();


        }
    }
}
