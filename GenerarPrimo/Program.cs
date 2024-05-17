using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerarPrimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solicitar desde y hasta");
            int desde = Convert.ToInt32(Console.ReadLine());
            int hasta = Convert.ToInt32(Console.ReadLine());

            for (int n = desde; n <= hasta; n++)
            {
                Console.WriteLine("ingrese el numero");

                int numero = Convert.ToInt32(Console.ReadLine());

                #region contar divisibilidades

                int divisibilidades = 0;
                for (int m = 1; m <= numero; m ++) 
                {
                    if (numero % m == 0)
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
                #endregion
            }
        }
    }
}
