using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        

        static int DevolverNumero(int posicion) {

            int a = 0, b = 1, d, aux;


                for (d = 0; d < posicion; d++) {

                    aux = a;
                    a = b;
                    b = aux + a;
                                 
                }
                
            return a;
        }

        static void Main(string[] args)
        {
            int i = 1;
            while (i > 0)
            {
                string entrada;
                Console.Write("Cual numero de Fibonacci desea \n");
                int posicion, numero;

                entrada = Console.ReadLine();
                posicion = Int32.Parse(entrada);

                numero = DevolverNumero(posicion);

                Console.WriteLine("El numero "+ posicion +" de la serie de Fibonacci es: " +numero);
            }
        }
    }
}
