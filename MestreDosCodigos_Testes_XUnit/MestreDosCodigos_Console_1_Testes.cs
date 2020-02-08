using FluentAssertions;
using MestreDosCodigos_Console_1.Model;
using Xunit;

namespace MestreDosCodigos_Testes_XUnit
{
    public class MestreDosCodigos_Console_1_Testes
    {
        [Fact]
        public void OperacaoSomaOk()
        {
            int a = 10;
            int b = 3;
            int valorEsperado = 13;

            var operacao = new Operacao(a, b);

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
        [Fact]
        public void OperacaoMultiplicacaoOk()
        {
            int a = 10;
            int b = 3;
            int valorEsperado = 30;

            var operacao = new Operacao(a, b);

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
        [Fact]
        public void OperacaoSubtracaoOk()
        {
            int a = 10;
            int b = 3;
            int valorEsperado = 7;

            var operacao = new Operacao(a, b);

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
        [Fact]
        public void OperacaoDivisaoOk()
        {
            int a = 2;
            int b = 50;
            int valorEsperado = 25;

            var operacao = new Operacao(a, b);

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
