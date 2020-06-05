using MestreDosCodigos_POO_3.Interface;
using MestreDosCodigos_Util.Resources;
using System;

namespace MestreDosCodigos_POO_3.Model
{
    public class ContaEspecial : ContaBancaria, IContaBancaria
    {
        public double Limite { get; private set; }

        public ContaEspecial(double limite, double saldo, int numeroConta)
        {
            Limite = limite;
            Saldo = saldo;
            NumeroConta = numeroConta;
        }

        public override void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                return;
            }

            throw new Exception(Resources.DepositoContaEspecialInvalido);
        }

        public override void Sacar(double valor)
        {
            var permiteSacar = (Saldo + Limite) >= valor;
            if (permiteSacar)
            {
                Saldo -= valor;
                return;
            }

            throw new Exception(Resources.SaqueContaEspecialInvalido);
        }

        public void MostraDados()
        {
            Console.WriteLine($"Número da conta: {NumeroConta}");
            Console.WriteLine($"Saldo: R$ {Saldo}");
            Console.WriteLine($"Limite: R$ {Limite}");
            Console.WriteLine();
        }
    }
}
