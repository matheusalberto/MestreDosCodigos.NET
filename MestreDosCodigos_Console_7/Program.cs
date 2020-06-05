using MestreDosCodigos_Util;
using System;

namespace MestreDosCodigos_Console_7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var qtdeNumeros = 4;
                var result = 0;

                for (int i = 1; i <= qtdeNumeros; i++)
                {
                    Console.Write($"Digite o número {i}:");
                    var numeroDigitado = OperacoesConsole.ObterInteiro();
                    result += numeroDigitado % 2 == 0 ? numeroDigitado : 0;
                }

                Console.WriteLine($"A soma dos pares é de: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
