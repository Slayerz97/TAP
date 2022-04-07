using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECURSIVIDAD
{
    class Program
    {
        
        public static int potencia(int a, int b)
        {
            if (b == 0)
                return 1;
            else
                return (a * potencia(a, b - 1));




           static void Main(string[] args)
           { Console.WriteLine("La potencia es:" + potencia(2, 2));
                Console.ReadKey();

           }

       
           

        



        
        

             

        }
    }
}
