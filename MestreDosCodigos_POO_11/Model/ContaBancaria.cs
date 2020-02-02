namespace MestreDosCodigos_POO_11.Model
{
    public abstract class ContaBancaria
    {
        public double Saldo { get; protected set; }
        public int NumeroConta { get; protected set; }

        public abstract void Sacar(double valor);
        public abstract void Depositar(double valor);
    }
}
