using MestreDosCodigos_POO_11.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MestreDosCodigos_POO_11.Model
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
            }

            //throw new Exception("Operação Inválida, o valor deve ser maior do que a taxa de operação!");
        }

        public override void Sacar(double valor)
        {
            if ((valor - this.TaxaDeOperacao) >= this.Saldo)
            {
                this.Saldo -= (valor - this.TaxaDeOperacao);
            }

            //throw new Exception("Operação Inválida, o valor = a taxa de instalação não pode ser maior do que seu saldo!");
        }

        public void MostraDados()
        {
            Console.WriteLine($"Número da conta: {this.NumeroConta}");
            Console.WriteLine($"Saldo: R$ {this.Saldo}");
            Console.WriteLine($"Taxa de Operação: R$ {this.TaxaDeOperacao}");
            Console.WriteLine();
        }
    }
}
