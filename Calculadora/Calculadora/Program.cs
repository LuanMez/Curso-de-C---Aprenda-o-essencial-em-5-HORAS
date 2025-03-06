using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 1;
            //coloquei num1=0 e num2=0 pois tem horas que nao recebem nenhum valor e deu erro no codigo
            int num1=0, num2=0, resultado;

            while (opcao!=0)
            {
                Console.WriteLine("Digite o número referente ao calculo desejado.");
                Console.WriteLine("1. Soma");
                Console.WriteLine("2. Subtracao");
                Console.WriteLine("3. Multiplicacao");
                Console.WriteLine("4. Divisao");
                Console.WriteLine("0. Para acabar os calculos");

                opcao = int.Parse(Console.ReadLine());

                if (opcao != 0)
                {
                    Console.WriteLine("Digite o num1: ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o num2: ");
                    num2 = int.Parse(Console.ReadLine());
                }

                switch (opcao)
                {
                    case 0:
                        opcao = 0;
                        break;
                    case 1:
                        resultado = som(num1, num2);
                        Console.WriteLine(resultado);
                        break;
                    case 2:
                        resultado = sub(num1, num2);
                        Console.WriteLine(resultado);
                        break;
                    case 3:
                        resultado = mult(num1, num2);
                        Console.WriteLine(resultado);
                        break;
                    case 4:
                        resultado = div(num1, num2);
                        Console.WriteLine(resultado);
                        break;
                    default:
                        Console.WriteLine("Digite uma opção valida!!");
                        break;

                }
            }
            Console.ReadLine();
        }

        static int som( int num1, int num2)
        {
            return num1 + num2;
        }

        static int sub(int num1, int num2)
        {
            return num1 - num2;
        }

        static int mult(int num1, int num2)
        {
            return num1 * num2;
        }

        static int div(int num1, int num2)
        {
            return num1 / num2;
        }


    }
}
