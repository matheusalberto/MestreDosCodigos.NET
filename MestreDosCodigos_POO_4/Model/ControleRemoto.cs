using MestreDosCodigos_Util.Resources;
using System;

namespace MestreDosCodigos_POO_4.Model
{
    public class ControleRemoto
    {
        public Televisao Televisao { get; set; }

        private int VolumeMaximo = 100;
        private int VolumeMinimo = 0;

        public void AumentarVolume()
        {
            if (Televisao.Volume < VolumeMaximo)
            {
                Televisao.Volume += 1;
            }
        }
        public void DiminuirVolume()
        {
            if (Televisao.Volume > VolumeMinimo)
            {
                Televisao.Volume -= 1;
            }
        }

        public void ProximoCanal()
        {
            var canalAtualIndice = Televisao.Canais.FindIndex(x => x == Televisao.CanalAtual);

            if (Televisao.Canais.Count - 1 != canalAtualIndice)
            {
                Televisao.CanalAtual = Televisao.Canais[canalAtualIndice + 1];
                return;
            }

            Televisao.CanalAtual = Televisao.Canais[0];
        }
        public void VoltarCanal()
        {
            var canalAtualIndice = Televisao.Canais.FindIndex(x => x == Televisao.CanalAtual);

            if (canalAtualIndice > 0)
            {
                Televisao.CanalAtual = Televisao.Canais[canalAtualIndice - 1];
                return;
            }

            Televisao.CanalAtual = Televisao.Canais[Televisao.Canais.Count - 1];
        }

        public void IndicarCanal(int canal)
        {
            var canalExiste = Televisao.Canais.Exists(x => x == canal);
            if (!canalExiste)
            {
                throw new Exception($"{Resources.Canal} {canal} {Resources.Inexistente}");
            }

            Televisao.CanalAtual = canal;
        }
    }
}
