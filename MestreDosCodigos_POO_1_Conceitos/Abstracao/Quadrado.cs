namespace MestreDosCodigos_POO_1_Conceitos.Abstracao
{
    public class Quadrado : Forma
    {
        public Quadrado(double lado) => Lado = lado;

        public double Lado { get; set; }

        public override void CalcularArea() => Area = Lado * Lado;

        public override void CalcularPerimetro() => Perimetro = 4 * Lado;
    }
}
