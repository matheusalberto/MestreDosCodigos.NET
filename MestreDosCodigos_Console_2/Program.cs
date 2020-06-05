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
                var qtdeFuncionarios = OperacoesConsole.ObterInteiro();
                var salarios = new List<int>();

                int contadorFuncionario = 1;
                while (qtdeFuncionarios > 0)
                {
                    Console.WriteLine($"Informe o salário do funcionário {contadorFuncionario}:");
                    var salario = OperacoesConsole.ObterInteiro();
                    salarios.Add(salario);
                    contadorFuncionario += 1;
                    qtdeFuncionarios -= 1;
                }

                var maiorSalario = 0;
                var menorSalario = int.MaxValue;
                for (int i = 0; i < salarios.Count; i++)
                {
                    var valorSalario = salarios[i];
                    if (valorSalario > maiorSalario) maiorSalario = valorSalario;
                    if (valorSalario < menorSalario) menorSalario = valorSalario;
                }

                Console.WriteLine($"O maior sálario é de: {maiorSalario}");
                Console.WriteLine($"O menor sálario é de: {menorSalario}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
