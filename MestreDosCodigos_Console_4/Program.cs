using MestreDosCodigos_Console_4.Model;
using MestreDosCodigos_Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MestreDosCodigos_Console_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de alunos:");
            var strQtdeAlunos = Console.ReadLine();

            try
            {
                var qtdeAlunos = strQtdeAlunos.toInt();
                List<Aluno> alunos = new List<Aluno>();
                var opcoes = Enumerable.Range(1, qtdeAlunos).ToList();

                foreach (var i in opcoes)
                {
                    Console.WriteLine(string.Format("Digite o nome do aluno {0}: ", i));
                    var nome = Console.ReadLine();
                    Console.WriteLine(string.Format("Digite a nota do aluno {0} (entre 0 e 10): ", i));
                    var nota = Console.ReadLine().toDouble();

                    if (nota < 0 || nota > 10)
                    {
                        throw new Exception("Valor de Nota inválido, o valor deve estar entre 0 e 10");
                    }

                    var aluno = new Aluno(nome, nota);
                    alunos.Add(aluno);
                }

                Console.WriteLine("Os alunos com média superior a 7 são:");
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
                    Console.WriteLine(string.Format("Aluno: {0} - Nota: {1}", aluno.Nome, aluno.Nota));
                }
            }
        }
    }
}
