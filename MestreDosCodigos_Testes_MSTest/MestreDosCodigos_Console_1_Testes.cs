using MestreDosCodigos_Console_1.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MestreDosCodigos_Console_1_Testes
{
    [TestClass]
    public class MestreDosCodigos_Console_1_Testes
    {
        [TestMethod]
        public void OperacaoSomaOk()
        {
            int a = 10;
            int b = 3;
            int valorEsperado = 13;

            var operacao = new Operacao(a, b);

            var resultado = operacao.Somar();

            Assert.AreEqual(valorEsperado, resultado);
        }

        [TestMethod]
        public void OperacaoSomaFalha()
        {
            int a = 10;
            int b = 3;
            int valorEsperado = 123;

            var operacao = new Operacao(a, b);

            var resultado = operacao.Somar();

            Assert.AreNotEqual(valorEsperado, resultado);
        }
        [TestMethod]
        public void OperacaoMultiplicacaoOk()
        {
            int a = 10;
            int b = 3;
            int valorEsperado = 30;

            var operacao = new Operacao(a, b);

            var resultado = operacao.Multiplicar();

            Assert.AreEqual(valorEsperado, resultado);
        }

        [TestMethod]
        public void OperacaoMultiplicacaoFalha()
        {
            int a = 10;
            int b = 3;
            int valorEsperado = 123;

            var operacao = new Operacao(a, b);

            var resultado = operacao.Multiplicar();

            Assert.AreNotEqual(valorEsperado, resultado);
        }
        [TestMethod]
        public void OperacaoSubtracaoOk()
        {
            int a = 10;
            int b = 3;
            int valorEsperado = 7;

            var operacao = new Operacao(a, b);

            var resultado = operacao.Subtrair();

            Assert.AreEqual(valorEsperado, resultado);
        }

        [TestMethod]
        public void OperacaoSubtracaoFalha()
        {
            int a = 10;
            int b = 3;
            int valorEsperado = 123;

            var operacao = new Operacao(a, b);

            var resultado = operacao.Subtrair();

            Assert.AreNotEqual(valorEsperado, resultado);
        }
        [TestMethod]
        public void OperacaoDivisaoOk()
        {
            int a = 2;
            int b = 50;
            int valorEsperado = 25;

            var operacao = new Operacao(a, b);

            var resultado = operacao.Dividir();

            Assert.AreEqual(valorEsperado, resultado);
        }

        [TestMethod]
        public void OperacaoDivisaoFalha()
        {
            int a = 50;
            int b = 50;
            int valorEsperado = 3;

            var operacao = new Operacao(a, b);

            var resultado = operacao.Dividir();

            Assert.AreNotEqual(valorEsperado, resultado);
        }
    }
}
