using MestreDosCodigos_Util;
using System;

namespace MestreDosCodigos_Console_5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite A:");
            var a = OperacoesConsole.ObterInteiro();

            Console.Write("Digite B:");
            var b = OperacoesConsole.ObterInteiro();

            Console.Write("Digite C:");
            var c = OperacoesConsole.ObterInteiro();

            try
            {
                var delta = b * b - 4 * a * c;

                var r1 = (-b + Math.Sqrt(delta)) / 2 * a;
                var r2 = (-b - Math.Sqrt(delta)) / 2 * a;

                Console.WriteLine($"R1: {r1}");
                Console.WriteLine($"R2: {r2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
