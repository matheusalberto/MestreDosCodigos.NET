using System;

namespace MestreDosCodigos_POO_2.Model
{
    public class Pessoa
    {
        private string Nome;
        private DateTime DataNascimento;
        private int Altura;

        public int getAltura() => this.Altura;
        public DateTime getDataNascimento() => this.DataNascimento;
        public string getNome() => this.Nome;
        public void setAltura(int altura) => this.Altura = altura;
        public void setDataNascimento(DateTime dataNascimento) => this.DataNascimento = dataNascimento;
        public void setNome(string nome) => this.Nome = nome;

        public void showDados()
        {
            Console.WriteLine(string.Format("Nome: {0}", this.Nome));
            Console.WriteLine(string.Format("Altura: {0}cm", this.Altura));
            Console.WriteLine(string.Format("Data Nascimento: {0}", this.DataNascimento.ToString("dd/MM/yyyy")));
        }

        public int getIdade()
        {
            var idade = DateTime.Now.Year - this.DataNascimento.Year;
            if (DateTime.Now.DayOfYear < this.DataNascimento.DayOfYear)
            {
                idade--;
            }

            return idade;
        }
    }
}
