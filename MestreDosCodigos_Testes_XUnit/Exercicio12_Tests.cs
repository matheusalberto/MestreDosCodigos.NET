using FluentAssertions;
using MestreDosCodigos_POO_12.Model;
using MestreDosCodigos_Util.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace MestreDosCodigos_Testes_XUnit
{
    public class Exercicio12_Tests
    {
        private List<int> Canais = new List<int> { 4, 6, 8, 10, 11, 13, 15, 22, 44 };
        private const int CanalPadrao = 8;
        private const int VolumePadrao = 20;

        [Fact]
        public void DeveAumentarVolume()
        {
            var televisao = new Televisao();
            televisao.Volume = VolumePadrao;

            var volumeEsperado = televisao.Volume + 1;

            var controle = new ControleRemoto();
            controle.Televisao = televisao;

            controle.AumentarVolume();

            televisao.Volume.Should().Be(volumeEsperado);
        }

        [Fact]
        public void DeveDiminuirVolume()
        {
            var televisao = new Televisao();
            televisao.Volume = VolumePadrao;

            var volumeEsperado = televisao.Volume - 1;

            var controle = new ControleRemoto();
            controle.Televisao = televisao;

            controle.DiminuirVolume();

            televisao.Volume.Should().Be(volumeEsperado);
        }

        [Fact]
        public void DeveIrParaOProximoCanalDaLista()
        {
            var televisao = new Televisao();
            televisao.Canais = Canais;
            televisao.CanalAtual = Canais.Last();

            var canalEsperado = Canais.First();

            var controle = new ControleRemoto();
            controle.Televisao = televisao;

            controle.ProximoCanal();

            televisao.CanalAtual.Should().Be(canalEsperado);
        }

        [Fact]
        public void DeveIrParaOCanalAnteriorDaLista()
        {
            var televisao = new Televisao();
            televisao.Canais = Canais;
            televisao.CanalAtual = Canais.First();

            var canalEsperado = Canais.Last();

            var controle = new ControleRemoto();
            controle.Televisao = televisao;

            controle.VoltarCanal();

            televisao.CanalAtual.Should().Be(canalEsperado);
        }

        [Fact]
        public void DeveIrParaOCanalIndicado()
        {
            var televisao = new Televisao();
            televisao.Canais = Canais;
            televisao.CanalAtual = CanalPadrao;

            var canalIndicado = 44;

            var controle = new ControleRemoto();
            controle.Televisao = televisao;

            controle.IndicarCanal(canalIndicado);

            televisao.CanalAtual.Should().Be(canalIndicado);
        }

        [Fact]
        public void DeveFalharIrParaOCanalIndicadoInexistente()
        {
            var televisao = new Televisao();
            televisao.Canais = Canais;
            televisao.CanalAtual = CanalPadrao;

            var canalIndicado = 555;

            var controle = new ControleRemoto();
            controle.Televisao = televisao;

            try
            {
                controle.IndicarCanal(canalIndicado);
                televisao.CanalAtual.Should().Be(canalIndicado);
            }
            catch(Exception ex)
            {
                var erroEsperado = string.Format(Resources.CanalInexistente, canalIndicado);
                ex.Message.Should().Be(erroEsperado);
            }            
        }
    }
}
