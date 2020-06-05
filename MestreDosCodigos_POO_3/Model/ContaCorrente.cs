using MestreDosCodigos_POO_3.Interface;
using MestreDosCodigos_Util.Resources;
using System;

namespace MestreDosCodigos_POO_3.Model
{
    public class ContaCorrente : ContaBancaria, IContaBancaria
    {
        public double TaxaDeOperacao { get; private set; }

        public ContaCorrente(double taxaDeOperacao, double saldo, int numeroConta)
        {
            TaxaDeOperacao = taxaDeOperacao;
            Saldo = saldo;
            NumeroConta = numeroConta;
        }

        public override void Depositar(double valor)
        {
            if (valor - TaxaDeOperacao > 0)
            {
                Saldo += valor - TaxaDeOperacao;
                return;
            }

            throw new Exception(Resources.DepositoContaCorrentInvalido);
        }

        public override void Sacar(double valor)
        {
            if ((valor + TaxaDeOperacao) <= Saldo)
            {
                Saldo -= (valor + TaxaDeOperacao);
                return;
            }

            throw new Exception(Resources.SaqueContaCorrenteInvalido);
        }

        public void MostraDados()
        {
            Console.WriteLine($"{Resources.NumeroConta} {NumeroConta}");
            Console.WriteLine($"{Resources.Saldo} {Saldo}");
            Console.WriteLine($"{Resources.TaxaOperacao} {TaxaDeOperacao}");
            Console.WriteLine();
        }
    }
}
