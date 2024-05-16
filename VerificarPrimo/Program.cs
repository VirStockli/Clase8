using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificarPrimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
                    
            Console.WriteLine("Ingrese un numero");
            string varText = Console.RedLine(); 
            int numero = Convert.ToInt32(varText);
            /* int numero = Conver.ToInt32(Console.ReadLine())*/

            int dividibikidades = 0;

            for (int n = 1;n <= numero; n++)
            { 
                if (numero % n ==0)
                {
                    divisibilidades++;
                }
            }
            if (divisibilidades <= 2)
            {
                Console.WriteLine("Es número primo")
            }
            else
            {
                Console.WriteLine("No es número primo")
            }
        }
    }
}
