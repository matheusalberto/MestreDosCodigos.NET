using FluentAssertions;
using MestreDosCodigos_POO_3.Model;
using MestreDosCodigos_Util.Resources;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MestreDosCodigos_Testes
{
    [TestClass]
    public class MestreDosCodigos_POO_2_Testes
    {
        [TestMethod]
        public void DeveDepositar()
        {
            double saldoInicial = 100;
            double valorDeposito = 100;
            double taxaOperacao = 10.5;

            var cc = new ContaCorrente(taxaOperacao, saldoInicial, 5678);
            cc.Depositar(valorDeposito);

            cc.Saldo.Should().Be(saldoInicial + valorDeposito - taxaOperacao);
        }

        [TestMethod]
        public void NaoDeveDepositar()
        {
            try
            {
                double saldoInicial = 100;
                double valorDeposito = 10;
                double taxaOperacao = 10.5;

                var cc = new ContaCorrente(taxaOperacao, saldoInicial, 5678);
                cc.Depositar(valorDeposito);

                Assert.Fail();
            }
            catch(Exception ex)
            {
                ex.Message.Should().Be(Resources.DepositoContaCorrentInvalido);
            }            
        }
    }
}
