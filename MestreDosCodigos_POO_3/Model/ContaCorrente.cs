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
            this.TaxaDeOperacao = taxaDeOperacao;
            this.Saldo = saldo;
            this.NumeroConta = numeroConta;
        }

        public override void Depositar(double valor)
        {
            if (valor - this.TaxaDeOperacao > 0)
            {
                this.Saldo += valor - this.TaxaDeOperacao;
                return;
            }

            throw new Exception(Resources.DepositoContaCorrentInvalido);
        }

        public override void Sacar(double valor)
        {
            if ((valor + this.TaxaDeOperacao) <= this.Saldo)
            {
                this.Saldo -= (valor + this.TaxaDeOperacao);
                return;
            }

            throw new Exception(Resources.SaqueContaCorrenteInvalido);
        }

        public void MostraDados()
        {
            Console.WriteLine(string.Format(Resources.NumeroConta, NumeroConta));
            Console.WriteLine(string.Format(Resources.Saldo, Saldo));
            Console.WriteLine(string.Format(Resources.TaxaOperacao, TaxaDeOperacao));
            Console.WriteLine();
        }
    }
}
