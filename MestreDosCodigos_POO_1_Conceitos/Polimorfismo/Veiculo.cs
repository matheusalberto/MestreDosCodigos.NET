namespace MestreDosCodigos_POO_1_Conceitos.Polimorfismo
{
    public class Veiculo
    {
        public string Tipo { get; set; }

        public Veiculo(string tipo)
        {
            Tipo = tipo;
        }

        public virtual void Mover() { }
        public virtual void Parar() { }
    }
}
