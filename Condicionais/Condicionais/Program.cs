using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            if(1 > 2)
            {
                Console.WriteLine("Verdadeiro");
            }
            else //else if
            {
                Console.WriteLine("Mentira");
            }

            //&& = e, || = ou;

            Console.ReadLine();
        }
    }
}
