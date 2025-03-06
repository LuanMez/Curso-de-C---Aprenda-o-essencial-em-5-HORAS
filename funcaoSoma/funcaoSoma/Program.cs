using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcaoSoma
{
    class Program
    {
        static void Main(string[] args)
        {

            int soma1 = (soma(1 ,2, 3));
            int soma2 = (soma(10, 20, 30));
            int soma3 = (soma(100, 200, 300));

            Console.WriteLine(soma1);
            Console.WriteLine(soma2);
            Console.WriteLine(soma3);

            Console.ReadLine();
        }

        static int soma(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
    }
}
