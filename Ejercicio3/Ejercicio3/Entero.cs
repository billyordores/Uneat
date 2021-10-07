using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{

    class Entero
    {
        public int number;
        public Entero(int numberTwo) {
            this.number = numberTwo;
        }

        public int CalcularCubo() {
            return (int)Math.Pow(number, 3);
        }
        public int CalcularCuadrado() {
            return (int)Math.Pow(number, 2);
        }
    }
}
