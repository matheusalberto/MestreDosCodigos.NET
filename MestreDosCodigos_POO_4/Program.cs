using MestreDosCodigos_POO_4.Model;
using System;
using System.Collections.Generic;

namespace MestreDosCodigos_POO_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var televisao = new Televisao();
                televisao.Canais = new List<int> { 4, 6, 8, 10, 11, 13, 15, 22, 44 };
                televisao.CanalAtual = 8;
                televisao.Volume = 20;

                var controle = new ControleRemoto();
                controle.Televisao = televisao;

                controle.Televisao.MostrarDados();

                controle.AumentarVolume();
                controle.AumentarVolume();
                controle.AumentarVolume();
                controle.AumentarVolume();
                controle.AumentarVolume();

                controle.DiminuirVolume();
                controle.DiminuirVolume();

                controle.ProximoCanal();
                controle.ProximoCanal();
                controle.ProximoCanal();
                controle.ProximoCanal();
                controle.ProximoCanal();
                controle.ProximoCanal();
                controle.ProximoCanal();
                controle.ProximoCanal();

                controle.VoltarCanal();
                controle.VoltarCanal();

                controle.IndicarCanal(8);

                controle.Televisao.MostrarDados();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
