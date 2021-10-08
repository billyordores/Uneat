using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Varios
    {   
        public void MostrarPrimos() {            
            for (int i=2; i<=30;i++ ) {
                if (EsPrimo(i)) {
                    Console.WriteLine($"El numero {i} es primo");
                }
            }    
        }
        public void MostrarNoPrimos() {
            Console.WriteLine("El numero 1 no es primo");
            for (int i = 2; i <= 30; i++)
            {
                if (!EsPrimo(i))
                {
                    Console.WriteLine($"El numero {i} no es primo");
                }
            }
        }

        static bool EsPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
