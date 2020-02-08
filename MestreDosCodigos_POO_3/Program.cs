using MestreDosCodigos_POO_3.Model;
using System;

namespace MestreDosCodigos_POO_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------------");
            ContaCorrente cc1 = new ContaCorrente(10.5, 100, 5678);
            Console.WriteLine("Valor inicial");
            cc1.MostraDados();
            cc1.Depositar(20);
            Console.WriteLine("Valor após depositar");
            cc1.MostraDados();
            cc1.Sacar(10);
            Console.WriteLine("Valor após sacar");
            cc1.MostraDados();

            Console.WriteLine("--------------------------------------------------------");
            ContaCorrente cc2 = new ContaCorrente(20, 50, 35678);
            Console.WriteLine("Valor inicial");
            cc2.MostraDados();
            cc2.Depositar(100);
            Console.WriteLine("Valor após depositar");
            cc2.MostraDados();
            cc2.Sacar(500);
            Console.WriteLine("Valor após sacar");
            cc2.MostraDados();

            Console.WriteLine("--------------------------------------------------------");
            ContaEspecial ce1 = new ContaEspecial(100, 1000, 4545);
            Console.WriteLine("Valor inicial");
            ce1.MostraDados();
            ce1.Depositar(100);
            Console.WriteLine("Valor após depositar");
            ce1.MostraDados();
            ce1.Sacar(500);
            Console.WriteLine("Valor após sacar");
            ce1.MostraDados();

            Console.WriteLine("--------------------------------------------------------");
            ContaEspecial ce2 = new ContaEspecial(15, 300, 65675);
            Console.WriteLine("Valor inicial");
            ce2.MostraDados();
            ce2.Depositar(10);
            Console.WriteLine("Valor após depositar");
            ce2.MostraDados();
            ce2.Sacar(1000);
            Console.WriteLine("Valor após sacar");
            ce2.MostraDados();
        }
    }
}
