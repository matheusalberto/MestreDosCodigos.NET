using System;
using System.Collections.Generic;
using System.Text;

namespace MestreDosCodigos_Util
{
    public static class OperacoesConsole
    {
        public static int ObterInteiro()
        {
            var resultado = 0;
            var validacaoOk = false;
            while (!validacaoOk)
            {
                try
                {                    
                    resultado = Console.ReadLine().ToInt();
                    validacaoOk = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Valor informado inválido. Tente novamente");
                }
            }
            return resultado;
        }

        public static double ObterNota()
        {
            var resultado = 0.0;
            var validacaoOk = false;
            while (!validacaoOk)
            {
                try
                {
                    resultado = Console.ReadLine().ToDouble();

                    if (resultado < 0 || resultado > 10)
                    {
                        throw new Exception("Valor de Nota inválido, o valor deve estar entre 0 e 10. Tente novamente");
                    }

                    validacaoOk = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Valor informado inválido. Tente novamente");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return resultado;
        }
    }
}
