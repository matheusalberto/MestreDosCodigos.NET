using MestreDosCodigos_Util.Resources;
using System;
using System.Collections.Generic;

namespace MestreDosCodigos_POO_4.Model
{
    public class Televisao
    {
        public int Volume { get; set; }
        public List<int> Canais { get; set; }
        public int CanalAtual { get; set; }

        public void MostrarDados()
        {
            Console.WriteLine($"{Resources.CanalAtual} {CanalAtual}");
            Console.WriteLine($"{Resources.VolumeAtual} {Volume}");
        }
    }
}
