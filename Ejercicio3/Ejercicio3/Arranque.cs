
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Arranque
    {
        static void Main(string[] args)
        {
            Entero newEntero = new Entero(20);
            Console.WriteLine($"el cuadrado de 20 es {newEntero.CalcularCuadrado()} ");
            Console.WriteLine($"el cubo de 20 es {newEntero.CalcularCubo()} ");

        }
    }
}
