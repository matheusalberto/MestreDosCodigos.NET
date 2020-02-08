namespace MestreDosCodigos_POO_Conceitos.Abstracao
{
    public class Quadrado : Forma
    {
        public Quadrado(double lado) => Lado = lado;

        public double Lado { get; set; }

        public override void CalcularArea() => this.Area = Lado * Lado;

        public override void CalcularPerimetro() => this.Perimetro = 4 * Lado;
    }
}
