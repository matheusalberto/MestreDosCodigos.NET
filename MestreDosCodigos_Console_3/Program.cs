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
                var contadorEhMultiploDeTres = contador % 3 == 0;
                if (contadorEhMultiploDeTres)
                {
                    Console.Write($"{contador} - ");
                }
                contador += 1;
            }
        }
    }
}
