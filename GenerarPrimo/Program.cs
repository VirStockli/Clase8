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
                for (int n = 1; n<= numero; n++) 
                {
                    if (numero % n == 0)
                    {
                        divisibilidades++;
                    }
                }
            }
        }
    }
}
