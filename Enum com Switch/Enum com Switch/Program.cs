using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_com_Switch
{
    class Program
    {
        //as strings nao precisam ser escritas com "Azul"
        //pode por valores em cada local como se fosse vetor
        //enum Cor { Azul = 2, Verde = 6, Amarelo = 123, Vermelho = 34}
        enum Cor { Azul, Verde, Rosa, Vermelho }
        //criar é 0, por isso botei ele igual a 1
        enum opcao { Criar = 1, Deletar, Editar, Listar, Atualizar }
        static void Main(string[] args)
        {

            Console.WriteLine("Selecione uma das opcoes abaixo");
            Console.WriteLine("1-Ciar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
            int index = int.Parse(Console.ReadLine());
            opcao opcaoSelecionada = (opcao)index;

            switch (opcaoSelecionada)
            {
                case opcao.Criar:
                    Console.WriteLine("Voce quer criar algo");
                    break;
                case opcao.Deletar:
                    Console.WriteLine("Voce quer deletar algo");
                    break;
                case opcao.Editar:
                    Console.WriteLine("Voce quer editar algo");
                    break;
                case opcao.Listar:
                    Console.WriteLine("Voce quer listar algo");
                    break;
                case opcao.Atualizar:
                    Console.WriteLine("Voce quer atualizar algo");
                    break;
            }

        }
    }
}
