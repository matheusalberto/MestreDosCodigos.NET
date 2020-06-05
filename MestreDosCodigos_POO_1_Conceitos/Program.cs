using MestreDosCodigos_POO_1_Conceitos.Abstracao;
using MestreDosCodigos_POO_1_Conceitos.Encapsulamento;
using MestreDosCodigos_POO_1_Conceitos.ExemplosInterfaces.Cloneable;
using MestreDosCodigos_POO_1_Conceitos.ExemplosInterfaces.Comparable;
using MestreDosCodigos_POO_1_Conceitos.ExemplosInterfaces.Disposable;
using MestreDosCodigos_POO_1_Conceitos.ExemplosInterfaces.Enumerable;
using MestreDosCodigos_POO_1_Conceitos.Polimorfismo;
using System;
using System.Collections.Generic;

namespace MestreDosCodigos_POO_1_Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Polimorfismo
            Veiculo[] veiculo = new Veiculo[2];

            veiculo[0] = new Automovel("Ferrari");
            veiculo[1] = new Aeronave("Tucano");

            veiculo[0].Mover();
            veiculo[1].Mover();

            // Abstração
            var quadrado = new Quadrado(10);
            quadrado.CalcularArea();
            quadrado.CalcularPerimetro();
            Console.WriteLine($"Area: {quadrado.Area}");
            Console.WriteLine($"Perímetro: {quadrado.Perimetro}");

            // Encapsulamento
            var conta = new Conta();
            // conta.Saldo = 100; -Não consido usar
            conta.Depositar(100);

            // IDisposable: Fornece um mecanismo para liberar recursos não gerenciados. 
            LogWriter log = new LogWriter("ArquivoLog.txt");
            log.Dispose();

            // IComparable: Define um método de comparação de tipo específico generalizado que implementa uma classe ou um tipo de valor para solicitar ou classificar suas instâncias.
            var listaTemperaturas = new List<Temperatura>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int temperatura = rnd.Next(0, 100);
                Temperatura temp = new Temperatura();
                temp.Fahrenheit = temperatura;
                listaTemperaturas.Add(temp);
            }

            listaTemperaturas.Sort(); // O comparador padrão agora é o que implementamos

            foreach (Temperatura temp in listaTemperaturas)
                Console.WriteLine(temp.Fahrenheit);

            // ICloneable
            var jose = new Pessoa("José", "Santana", 33);
            var joseClone = jose.Clone();

            // IEnumerable
            var cesta = new Cesta(new string[] { "Banana", "Abacaxi", "Uva" });
            foreach(var fruta in cesta)
            {
                Console.WriteLine(fruta);
            }
        }
    }
}
