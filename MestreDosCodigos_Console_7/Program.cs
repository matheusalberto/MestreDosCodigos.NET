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
                    Console.Write(string.Format("Digite o número {0}:", i));
                    var numeroDigitado = Console.ReadLine().toInt();
                    result += numeroDigitado.isPair() ? numeroDigitado : 0;
                }

                Console.WriteLine(string.Format("A soma dos pares é de: {0}", result));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
