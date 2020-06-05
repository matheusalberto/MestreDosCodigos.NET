using MestreDosCodigos_Console_1.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MestreDosCodigos_Console_1_Testes
{
    [TestClass]
    public class MestreDosCodigos_Console_1_Testes
    {
        [TestMethod]
        [DataRow(10, 12, 22)]
        [DataRow(45, 15, 60)]
        [DataRow(100, 15, 115)]
        public void TestesSomaOk(int valor1, int valor2, int valorEsperado)
        {
            var operacao = new Operacao(valor1, valor2);

            var resultado = operacao.Somar();

            Assert.AreEqual(valorEsperado, resultado);
        }

        [TestMethod]
        [DataRow(10, 12, 222)]
        [DataRow(45, 15, 4515)]
        [DataRow(100, 15, 10015)]
        public void TestesSomaFalha(int valor1, int valor2, int valorEsperado)
        {
            var operacao = new Operacao(valor1, valor2);

            var resultado = operacao.Somar();

            Assert.AreNotEqual(valorEsperado, resultado);
        }

        [TestMethod]
        [DataRow(10, 12, 120)]
        [DataRow(10, 15, 150)]
        [DataRow(100, 10, 1000)]
        public void TestesMultiplicacaoOk(int valor1, int valor2, int valorEsperado)
        {
            var operacao = new Operacao(valor1, valor2);

            var resultado = operacao.Multiplicar();

            Assert.AreEqual(valorEsperado, resultado);
        }

        [TestMethod]
        [DataRow(10, 12, 222)]
        [DataRow(45, 15, 4515)]
        [DataRow(100, 15, 10015)]
        public void TestesMultiplicacaoFalha(int valor1, int valor2, int valorEsperado)
        {
            var operacao = new Operacao(valor1, valor2);

            var resultado = operacao.Multiplicar();

            Assert.AreNotEqual(valorEsperado, resultado);
        }

        [TestMethod]
        [DataRow(10, 12, -2)]
        [DataRow(10, 15, -5)]
        [DataRow(100, 10, 90)]
        public void TestesSubtracaoOk(int valor1, int valor2, int valorEsperado)
        {
            var operacao = new Operacao(valor1, valor2);

            var resultado = operacao.Subtrair();

            Assert.AreEqual(valorEsperado, resultado);
        }

        [TestMethod]
        [DataRow(10, 12, 222)]
        [DataRow(45, 15, 4515)]
        [DataRow(100, 15, 10015)]
        public void TestesSubtracaoFalha(int valor1, int valor2, int valorEsperado)
        {
            var operacao = new Operacao(valor1, valor2);

            var resultado = operacao.Subtrair();

            Assert.AreNotEqual(valorEsperado, resultado);
        }

        [TestMethod]
        [DataRow(2, 10, 5)]
        [DataRow(4, 10, 2.5)]
        [DataRow(10, 100, 10)]
        public void TestesDivisaoOk(int valor1, int valor2, double valorEsperado)
        {
            var operacao = new Operacao(valor1, valor2);

            var resultado = operacao.Dividir();

            Assert.AreEqual(valorEsperado, resultado);
        }

        [TestMethod]
        [DataRow(10, 12, 222)]
        [DataRow(45, 15, 4515)]
        [DataRow(100, 15, 10015)]
        public void TestesDivisaoFalha(int valor1, int valor2, int valorEsperado)
        {
            var operacao = new Operacao(valor1, valor2);

            var resultado = operacao.Dividir();

            Assert.AreNotEqual(valorEsperado, resultado);
        }
    }
}
