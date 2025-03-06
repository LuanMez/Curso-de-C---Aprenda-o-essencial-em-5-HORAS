using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            //*Variaveis*
            //*Int - - 123, 345
            //*Float - -12.3, 345.345 ===> Existe Double e Decimal
            //*Bool - true ou false
            //*String - "texto"
            //*Char - 'a' um único caracter

            int dia_da_guerra = 1942;
            string cor_favorita = "vermelho";
            float velocidadeF1 = 294.98f; //tem que por um f no final para dizer que é float
            bool dia_da_guerraAconteceu = true;

            Console.WriteLine(dia_da_guerra);
            Console.WriteLine(cor_favorita);
            Console.WriteLine(velocidadeF1);
            Console.WriteLine(dia_da_guerraAconteceu);

            //alterar valor da variavel igual c
            velocidadeF1 = 348.34f;

            //*Var - variavel que interpreta a tipagem
            var meuTexto = "Hello World"; //interpreto que é uma string
            Console.WriteLine(meuTexto);
            var numero = 24;
            Console.WriteLine(numero); //interpretou que é um int

            //exemplo de erro
            //var valor;  // Erro! O compilador não pode inferir o tipo sem inicialização
            //valor = 10;

            //*Dynamic - variavel que pode alterar o tipo a qualquer momento
            Console.WriteLine(velocidadeF1);

            dynamic cor = "vermelho";

            Console.WriteLine(cor);

            cor = 1234;

            Console.WriteLine(cor);

            //*Constantes*
            //elas não podem ser mudadas igual as varaiveis
            const float PI = 3.14f;


            Console.ReadLine(); //fazer com que o programa não feche sozinho
        }
    }
}
