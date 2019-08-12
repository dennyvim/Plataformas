using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaracteresPlataformas
{
    class Program
    {


        static void Main(string[] args)
        {
            string[] a = new string[5] { "$", "!", "#", "?", "-" };
            var b = a.ToList();

            // Entradas ya usted solo pide los datos, melo? UF TE AMO HPTA te voy es a mamar esa vergajajajajaj gracias Bianfa  tlodoov ebie
            int rows = 4;
            int nCharacters = 5;
            int position = 7;
            int account = 1;
            String value = "desconocido";

            for(int i = b.Count(); i > nCharacters; i--)
            {
                b.RemoveAt(i - 1);
            }

            for(int j = 0; j < rows; j++)
            {

                for(int k = 0; k < b.Count(); k++)
                {
                    Console.Write(b[k] + " ");
                    if(account == position)
                    {
                        value = b[k];
                    }
                    if (!b[k].Equals("."))
                    {                        
                        account++;
                    }
                }
                Console.WriteLine();

                b.Add(b[j]);
                b[j] = ".";

            }

            Console.WriteLine("El caracter numero "+ position +" es el " + value);

        }
    }
}
