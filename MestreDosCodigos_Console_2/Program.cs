using MestreDosCodigos_Util;
using System;
using System.Collections.Generic;

namespace MestreDosCodigos_Console_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite o número de funcionários:");
                var strQtdeFuncionarios = Console.ReadLine();
                var qtdeFuncionarios = strQtdeFuncionarios.toInt();
                List<int> salarios = new List<int>();

                int contadorFuncionario = 1;
                while (qtdeFuncionarios > 0)
                {
                    Console.WriteLine(string.Format("Informe o salário do funcionário {0}:", contadorFuncionario++));
                    var strSalario = Console.ReadLine();
                    var salario = strSalario.toInt();
                    salarios.Add(salario);
                    qtdeFuncionarios--;
                }

                var maiorSalario = 0;
                var menorSalario = int.MaxValue;
                for (int i = 0; i < salarios.Count; i++)
                {
                    var valorSalario = salarios[i];
                    if (valorSalario > maiorSalario) maiorSalario = valorSalario;
                    if (valorSalario < menorSalario) menorSalario = valorSalario;
                }

                Console.WriteLine(string.Format("O maior sálario é de: {0}", maiorSalario));
                Console.WriteLine(string.Format("O menor sálario é de: {0}", menorSalario));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
