using MestreDosCodigos_Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MestreDosCodigos_Console_9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var lista = new List<int>();
            Console.WriteLine("Digite o número N:");
            var N = OperacoesConsole.ObterInteiro();

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Digite o número {i + 1}:");
                var valor = OperacoesConsole.ObterInteiro();
                lista.Add(valor);
            }

            Console.WriteLine("Lista Original:");
            Console.WriteLine(mostrarLista(lista));

            Console.WriteLine("Lista Crescente:");
            Console.WriteLine(mostrarLista(lista.OrderBy(x => x).ToList()));

            Console.WriteLine("Lista Decrescente:");
            Console.WriteLine(mostrarLista(lista.OrderByDescending(x => x).ToList()));

            Console.WriteLine("Primeiro elemento da lista:");
            Console.WriteLine(lista.First());

            Console.WriteLine("Último elemento da lista:");
            Console.WriteLine(lista.Last());

            Console.WriteLine("Inserindo o número 999 no início da lista:");
            lista.Insert(0, 999);
            Console.WriteLine(mostrarLista(lista));

            Console.WriteLine("Inserindo o número 999 no final da lista:");
            lista.Insert(lista.Count, 999);
            Console.WriteLine(mostrarLista(lista));

            Console.WriteLine("Removendo primeiro elemento da lista:");
            lista.RemoveAt(0);
            Console.WriteLine(mostrarLista(lista));

            Console.WriteLine("Removendo último elemento da lista:");
            lista.RemoveAt(lista.Count - 1);
            Console.WriteLine(mostrarLista(lista));

            Console.WriteLine("Apenas pares:");
            Console.WriteLine(mostrarLista(lista.Where(x => x % 2 == 0).ToList()));

            Console.WriteLine("Todos os elementos da lista em um Array: " + lista.ToArray());
        }

        private static string mostrarLista(List<int> lista)
        {
            var ret = string.Empty;
            foreach (var valor in lista)
            {
                ret += $"{valor} ";
            }
            return ret;
        }
    }
}
