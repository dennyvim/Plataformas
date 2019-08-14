using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadenas
{
    class Program
    {

        static void generarCarater(int lon) {



            Guid miGuid = Guid.NewGuid();
            string token = Convert.ToBase64String(miGuid.ToByteArray());
            token = token.Replace("=", "").Replace("+", "").Replace("/", "");
            if (lon > 4)
            {

                token = token.Insert(0, "a");
            }

            Console.WriteLine(token.Substring(0, lon));

            



        }


        static void Main(string[] args)
        {

            Random r = new Random();


            int lon, i, j;

            for (i = 0; i <= 1000; i++) {

                Console.WriteLine(i);
                lon = r.Next(2, 10);
                generarCarater(lon);
            }
                

        }
    }
}
