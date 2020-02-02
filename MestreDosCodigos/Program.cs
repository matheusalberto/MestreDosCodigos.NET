using MestreDosCodigos_Console_1.Enum;
using MestreDosCodigos_Console_1.Model;
using MestreDosCodigos_Util;
using System;

namespace MestreDosCodigos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite A:");
            var strA = Console.ReadLine();

            Console.WriteLine("Digite B:");
            var strB = Console.ReadLine();

            var operacao = new Operacao(strA.toInt(), strB.toInt());

            try
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1. SOMAR");
                Console.WriteLine("2. SUBTRAIR");
                Console.WriteLine("3. MULTIPLICAR");
                Console.WriteLine("4. DIVIDIR");
                Console.WriteLine("5. VERIFICAR PARIDADE");
                var resp = Console.ReadLine();

                switch ((TipoOperacao)resp.toInt())
                {
                    case TipoOperacao.SOMAR:
                        Console.WriteLine($"A+B:{operacao.Somar()}");
                        break;
                    case TipoOperacao.SUBTRAIR:
                        Console.WriteLine($"A-B:{operacao.Subtrair()}");
                        break;
                    case TipoOperacao.MULTIPLICAR:
                        Console.WriteLine($"A*B:{operacao.Multiplicar()}");
                        break;
                    case TipoOperacao.DIVIDIR:
                        Console.WriteLine($"B/A:{operacao.Dividir()}");
                        break;
                    case TipoOperacao.VERIFICAR_PARIDADE:
                        Console.WriteLine($"A ({operacao.A}) é {(operacao.A.isPair() ? "PAR" : "ÍMPAR")}");
                        Console.WriteLine($"B ({operacao.B}) é {(operacao.B.isPair() ? "PAR" : "ÍMPAR")}");
                        break;
                    default:
                        throw new Exception("Valor inválido");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("*******************************************");
                Console.WriteLine(ex.Message);
                Console.WriteLine("*******************************************");
            }
        }
    }
}
