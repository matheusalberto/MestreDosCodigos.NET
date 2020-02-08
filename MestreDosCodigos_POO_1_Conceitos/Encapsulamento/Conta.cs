namespace MestreDosCodigos_POO_1_Conceitos.Encapsulamento
{
    public class Conta
    {
        //Não podemos alterar o saldo diretamente, somente passando por um dos métodos
        private double Saldo;

        public void Sacar(double valor) => Saldo -= valor;
        public void Depositar(double valor) => Saldo += valor;
    }
}
