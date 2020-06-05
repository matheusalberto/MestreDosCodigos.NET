namespace MestreDosCodigos_POO_1_Conceitos.Encapsulamento
{
    public class Conta
    {
        // Não podemos alterar o saldo diretamente, somente passando por um dos métodos
        public double Saldo { get; private set; }

        public void Sacar(double valor) => Saldo -= valor;
        public void Depositar(double valor) => Saldo += valor;
    }
}
