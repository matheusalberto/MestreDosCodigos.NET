using FluentAssertions;
using MestreDosCodigos_POO_3.Model;
using MestreDosCodigos_Util.Resources;
using System;
using Xunit;

namespace MestreDosCodigos_Testes_XUnit
{
    public class MestreDosCodigos_POO_2_Testes
    {
        [Fact]
        public void DeveDepositarContaCorrente()
        {
            double saldoInicial = 100;
            double valorDeposito = 100;
            double taxaOperacao = 10.5;

            var cc = new ContaCorrente(taxaOperacao, saldoInicial, 5678);
            cc.Depositar(valorDeposito);

            cc.Saldo.Should().Be(saldoInicial + valorDeposito - taxaOperacao);
        }

        [Fact]
        public void NaoDeveDepositarContaCorrente()
        {
            try
            {
                double saldoInicial = 100;
                double valorDeposito = 10;
                double taxaOperacao = 10.5;

                var cc = new ContaCorrente(taxaOperacao, saldoInicial, 5678);
                cc.Depositar(valorDeposito);
            }
            catch(Exception ex)
            {
                ex.Message.Should().Be(Resources.DepositoContaCorrentInvalido);
            }
        }

        [Fact]
        public void DeveDepositarContaEspecial()
        {
            double saldoInicial = 100;
            double valorDeposito = 100;
            double limite = 1000;

            var ce = new ContaEspecial(limite, saldoInicial, 5678);
            ce.Depositar(valorDeposito);

            ce.Saldo.Should().Be(saldoInicial + valorDeposito);
        }

        [Fact]
        public void NaoDeveDepositarContaEspecial()
        {
            try
            {
                double saldoInicial = 100;
                double valorDeposito = -10;
                double limite = 10.5;

                var ce = new ContaEspecial(limite, saldoInicial, 5678);
                ce.Depositar(valorDeposito);
            }
            catch(Exception ex)
            {
                ex.Message.Should().Be(Resources.DepositoContaEspecialInvalido);
            }            
        }

        [Fact]
        public void DeveSacarContaEspecial()
        {
            double saldoInicial = 100;
            double valorSaque = 10;
            double limite = 1000;

            var ce = new ContaEspecial(limite, saldoInicial, 5678);
            ce.Sacar(valorSaque);

            ce.Saldo.Should().Be(saldoInicial - valorSaque);
        }

        [Fact]
        public void NaoDeveSacarContaEspecial()
        {
            try
            {
                double saldoInicial = 100;
                double valorSaque = 1000;
                double limite = 500;

                var ce = new ContaEspecial(limite, saldoInicial, 5678);
                ce.Sacar(valorSaque);
            }
            catch(Exception ex)
            {
                ex.Message.Should().Be(Resources.SaqueContaEspecialInvalido);
            }
        }

        [Fact]
        public void DeveSacarContaCorrente()
        {
            double saldoInicial = 100;
            double valorSaque = 10;
            double taxaOperacao = 10.5;

            var cc = new ContaCorrente(taxaOperacao, saldoInicial, 5678);
            cc.Sacar(valorSaque);

            cc.Saldo.Should().Be(saldoInicial - taxaOperacao - valorSaque);
        }

        [Fact]
        public void NaoDeveSacarContaCorrente()
        {
            try
            {
                double saldoInicial = 100;
                double valorSaque = 95;
                double limite = 10.5;

                var cc = new ContaCorrente(limite, saldoInicial, 5678);
                cc.Sacar(valorSaque);
            }
            catch(Exception ex)
            {
                ex.Message.Should().Be(Resources.SaqueContaCorrenteInvalido);
            }
        }
    }
}
