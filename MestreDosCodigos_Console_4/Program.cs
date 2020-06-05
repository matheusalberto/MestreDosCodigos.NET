using MestreDosCodigos_Console_4.Model;
using MestreDosCodigos_Util;
using System;
using System.Collections.Generic;

namespace MestreDosCodigos_Console_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de alunos:");
            var qtdeAlunos = OperacoesConsole.ObterInteiro();

            try
            {
                var alunos = new List<Aluno>();
                var contadorAluno = 1;

                while (contadorAluno < qtdeAlunos)
                {
                    Console.WriteLine($"Digite o nome do aluno {contadorAluno}: ");
                    var nome = Console.ReadLine();

                    Console.WriteLine($"Digite a nota do aluno {contadorAluno} (entre 0 e 10): ");
                    var nota = OperacoesConsole.ObterNota();

                    var aluno = new Aluno(nome, nota);
                    alunos.Add(aluno);
                }

                Console.WriteLine("Os alunos com média superior a 7 são: ");
                MostrarAlunosComMediaSuperior7(alunos);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void MostrarAlunosComMediaSuperior7(List<Aluno> alunos)
        {
            foreach (var aluno in alunos)
            {
                if (aluno.TemNotaAzul())
                {
                    Console.WriteLine($"Aluno: {aluno.Nome} - Nota: {aluno.Nota}");
                }
            }
        }
    }
}
