using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class App
    {
        public static int Calculing(int indice)
        {
            int k = 0;
            int soma = 0;

            while (indice > k)
            {
                k++;
                soma = k + soma;
            }  

            return soma;
        }
    }
}
