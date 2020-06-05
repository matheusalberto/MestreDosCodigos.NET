using FluentAssertions;
using MestreDosCodigos_Console_1.Model;
using Xunit;

namespace MestreDosCodigos_Testes_XUnit
{
    public class MestreDosCodigos_Console_1_Testes
    {
        [Theory]
        [InlineData(5, 5, 10)]
        [InlineData(56, 5, 61)]
        [InlineData(5, 54, 59)]
        public void TestesSomaOk(int valor1, int valor2, int valorEsperado)
        {
            var operacao = new Operacao(valor1, valor2);

            var resultado = operacao.Somar();

            resultado.Should().Be(valorEsperado);
        }

        [Fact]
        public void OperacaoSomaFalha()
        {
            int a = 10;
            int b = 3;
            int valorEsperado = 123;

            var operacao = new Operacao(a, b);

            var resultado = operacao.Somar();

            resultado.Should().NotBe(valorEsperado);
        }

        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(56, 10, 560)]
        [InlineData(9, 9, 81)]
        public void TestesMultiplicacaoOk(int valor1, int valor2, int valorEsperado)
        {
            var operacao = new Operacao(valor1, valor2);

            var resultado = operacao.Multiplicar();

            resultado.Should().Be(valorEsperado);
        }

        [Fact]
        public void OperacaoMultiplicacaoFalha()
        {
            int a = 10;
            int b = 3;
            int valorEsperado = 123;

            var operacao = new Operacao(a, b);

            var resultado = operacao.Multiplicar();

            resultado.Should().NotBe(valorEsperado);
        }

        [Theory]
        [InlineData(5, 5, 0)]
        [InlineData(56, 10, 46)]
        [InlineData(109, 11, 98)]
        public void TestesSubtracaoOk(int valor1, int valor2, int valorEsperado)
        {
            var operacao = new Operacao(valor1, valor2);

            var resultado = operacao.Subtrair();

            resultado.Should().Be(valorEsperado);
        }

        [Fact]
        public void OperacaoSubtracaoFalha()
        {
            int a = 10;
            int b = 3;
            int valorEsperado = 123;

            var operacao = new Operacao(a, b);

            var resultado = operacao.Subtrair();

            resultado.Should().NotBe(valorEsperado);
        }

        [Theory]
        [InlineData(5, 5, 1)]
        [InlineData(10, 56, 5.6)]
        [InlineData(4, 1000, 250)]
        public void TestesDivisaoOk(int valor1, int valor2, double valorEsperado)
        {
            var operacao = new Operacao(valor1, valor2);

            var resultado = operacao.Dividir();

            resultado.Should().Be(valorEsperado);
        }

        [Fact]
        public void OperacaoDivisaoFalha()
        {
            int a = 50;
            int b = 50;
            int valorEsperado = 3;

            var operacao = new Operacao(a, b);

            var resultado = operacao.Dividir();

            resultado.Should().NotBe(valorEsperado);
        }
    }
}
