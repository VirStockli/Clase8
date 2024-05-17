using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerarPrimoconMetodo
{
    internal class Program
    {
        static bool VerificarPrimo()
        {
            Console.WriteLine("Ingrese un numero");
            string varText = Console.ReadLine();
            int numero = Convert.ToInt32(varText);

            /* int numero = Conver.ToInt32(Console.ReadLine())*/

            int divisibilidades = 0;

            for (int n = 1; n <= numero; n++)
            {
                if (numero % n == 0)
                {
                    divisibilidades++;
                }
            }
            if (divisibilidades <= 2)
            {
                Console.WriteLine("Es número primo");
            }
            else
            {
                Console.WriteLine("No es número primo");
            }
            return divisibilidades <= 2;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            string varText = Console.ReadLine();
            int numero = Convert.ToInt32(varText);
            /* int numero = Conver.ToInt32(Console.ReadLine())*/

            for (int m = 1; m <= numero; m++)
            {
                if (Program.VerificarPrimo() == true)
                {
                    Console.WriteLine("{O}", m);
                }

                Console.ReadKey();
            }
        }
    }
}
