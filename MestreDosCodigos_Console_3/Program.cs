using MestreDosCodigos_Util;
using System;

namespace MestreDosCodigos_Console_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var contador = 1;
            var valorMaximo = 100;

            while (contador < valorMaximo)
            {
                if (contador.isMultipleThree())
                {
                    Console.Write(string.Format("{0} - ", contador));
                }
                contador++;
            }
        }
    }
}
