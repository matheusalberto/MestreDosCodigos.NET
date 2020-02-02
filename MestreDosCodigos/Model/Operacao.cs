namespace MestreDosCodigos_Console_1.Model
{
    public class Operacao
    {
        public Operacao(int a, int b)
        {
            A = a;
            B = b;
        }

        public int A { get; private set; }
        public int B { get; private set; }

        public double Somar() => (A + B);
        public double Subtrair() => (A - B);
        public double Dividir() => (B / A);
        public double Multiplicar() => (A * B);
    }
}
