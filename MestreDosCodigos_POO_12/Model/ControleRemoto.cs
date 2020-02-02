namespace MestreDosCodigos_POO_12.Model
{
    public class ControleRemoto
    {
        public Televisao Televisao { get; set; }

        private int VolumeMaximo = 100;
        private int VolumeMinimo = 0;

        public void AumentarVolume()
        {
            if (this.Televisao.Volume < VolumeMaximo)
            {
                this.Televisao.Volume++;
            }
        }
        public void DiminuirVolume()
        {
            if (this.Televisao.Volume > VolumeMinimo)
            {
                this.Televisao.Volume--;
            }
        }

        public void ProximoCanal()
        {
            var canalAtualIndice = this.Televisao.Canais.FindIndex(x => x == this.Televisao.CanalAtual);

            if (this.Televisao.Canais.Count - 1 != canalAtualIndice)
            {
                this.Televisao.CanalAtual = this.Televisao.Canais[canalAtualIndice + 1];
                return;
            }

            this.Televisao.CanalAtual = this.Televisao.Canais[0];
        }
        public void VoltarCanal()
        {
            var canalAtualIndice = this.Televisao.Canais.FindIndex(x => x == this.Televisao.CanalAtual);

            if (canalAtualIndice > 0)
            {
                this.Televisao.CanalAtual = this.Televisao.Canais[canalAtualIndice - 1];
                return;
            }

            this.Televisao.CanalAtual = this.Televisao.Canais[this.Televisao.Canais.Count - 1];
        }

        public void IndicarCanal(int canal)
        {
            var canalExiste = this.Televisao.Canais.Exists(x => x == canal);
            if (!canalExiste)
            {
                throw new System.Exception($"Canal {canal} Inexistente");
            }

            this.Televisao.CanalAtual = canal;
        }
    }
}
