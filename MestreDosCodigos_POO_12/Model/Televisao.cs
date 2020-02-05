using MestreDosCodigos_Util.Resources;
using System;
using System.Collections.Generic;

namespace MestreDosCodigos_POO_12.Model
{
    public class Televisao
    {
        public int Volume { get; set; }
        public List<int> Canais { get; set; }
        public int CanalAtual { get; set; }

        public void MostrarDados()
        {
            Console.WriteLine(string.Format(Resources.CanalAtual, CanalAtual));
            Console.WriteLine(string.Format(Resources.VolumeAtual, Volume);
        }
    }
}
