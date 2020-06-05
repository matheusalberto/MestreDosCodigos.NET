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
            var valorA = OperacoesConsole.ObterInteiro();

            Console.WriteLine("Digite B:");
            var valorB = OperacoesConsole.ObterInteiro();

            var operacao = new Operacao(valorA, valorB);

            try
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1. SOMAR");
                Console.WriteLine("2. SUBTRAIR");
                Console.WriteLine("3. MULTIPLICAR");
                Console.WriteLine("4. DIVIDIR");
                Console.WriteLine("5. VERIFICAR PARIDADE");
                var opcao = OperacoesConsole.ObterInteiro();

                switch ((TipoOperacao)opcao)
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
                        Console.WriteLine($"A ({operacao.A}) é {(operacao.A % 2 == 0 ? "PAR" : "ÍMPAR")}");
                        Console.WriteLine($"B ({operacao.B}) é {(operacao.B % 2 == 0 ? "PAR" : "ÍMPAR")}");
                        break;
                    default:
                        throw new Exception("Opção inválida");
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é possível fazer divisão por 0. Tente novamente");
                Main(null);
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
