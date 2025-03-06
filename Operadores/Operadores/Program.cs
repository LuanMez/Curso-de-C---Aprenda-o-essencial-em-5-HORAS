using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroQualquer = 20 + 20 - 10;
            int numeroMult = 10 * 90;
            float numeroDiv = 5f / 2;

            int teste = (2 + 2) * 10;

            // 5 / 2 => 2.5 decimal no int
            Console.WriteLine(numeroQualquer);
            Console.WriteLine(numeroMult);
            Console.WriteLine(numeroDiv);
            Console.WriteLine(teste);

            Console.ReadLine();
        }
    }
}
