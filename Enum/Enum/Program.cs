using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        //as strings nao precisam ser escritas com "Azul"
        //pode por valores em cada local como se fosse vetor
        //enum Cor { Azul = 2, Verde = 6, Amarelo = 123, Vermelho = 34}
        enum Cor { Azul, Verde, Rosa, Vermelho}
        static void Main(string[] args)
        {
            Cor corLuan = Cor.Azul;
            Cor corKatia = Cor.Rosa;

            Console.WriteLine("Cor favorita do Luan é " + corLuan);
            Console.WriteLine("Cor favorita da Katia é " + corKatia);

            //casting converter um enum para seu inteiro
            Console.WriteLine("Cor favorita do Luan é " + (int)corLuan);

            //pegou o enum Cor e exibe qual está no 3
            Console.WriteLine("Cor favorita do Katia é " + (Cor)3);
        }
    }
}
