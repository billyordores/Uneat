using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int scanner = 0;
            while (scanner!=3) {
                
                Console.WriteLine("*------Menu-----*");
                Console.WriteLine("Opción 1-> MostrarPrimos");
                Console.WriteLine("Opción 2-> MostrarNoPrimos");
                Console.WriteLine("Opción 3-> Salir");
                Console.Write("->");
                scanner = Convert.ToInt32(Console.ReadLine());
                switch (scanner) {
                    case 1:
                        Varios var = new Varios();
                        var.MostrarPrimos();
                        break;
                    case 2:
                        Varios var2 = new Varios();
                        var2.MostrarNoPrimos();
                        break;
                }
                if (scanner != 2 & scanner != 1 & scanner != 3) {
                    Console.WriteLine("Opción no disponible");
                }
                Console.WriteLine("*----------------------*");

            }
        }
    }
}
