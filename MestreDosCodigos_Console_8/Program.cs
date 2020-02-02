using MestreDosCodigos_Console_8.Enum;
using MestreDosCodigos_Util;
using System;
using System.Collections.Generic;

namespace MestreDosCodigos_Console_8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                List<int> lista = new List<int>();
                Console.WriteLine("Digite o número N:");
                var strN = Console.ReadLine();

                for (int i = 0; i < strN.toInt(); i++)
                {
                    Console.WriteLine($"Digite o número {i + 1}:");
                    var valor = Console.ReadLine();
                    lista.Add(valor.toInt());
                }
                lista = insertionSort(lista);

                Console.WriteLine("Lista Crescente");
                mostrarListaPorOrdenacao(lista, Ordenacao.CRESCENTE);

                Console.WriteLine();

                Console.WriteLine("Lista Decrescente:");
                mostrarListaPorOrdenacao(lista, Ordenacao.DECRESCENTE);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static List<int> insertionSort(List<int> inputArray)
        {
            for (int i = 0; i < inputArray.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
            return inputArray;
        }

        private static void mostrarListaPorOrdenacao(List<int> lista, Ordenacao tipo)
        {
            if (tipo == Ordenacao.CRESCENTE)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    Console.Write($"{lista[i]} ");
                }
                return;
            }

            for (int i = lista.Count - 1; i >= 0; i--)
            {
                Console.Write($"{lista[i]} ");
            }
        }
    }
}
