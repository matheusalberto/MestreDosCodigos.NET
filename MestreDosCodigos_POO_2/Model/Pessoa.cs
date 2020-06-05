using System;

namespace MestreDosCodigos_POO_2.Model
{
    public class Pessoa
    {
        private string Nome;
        private DateTime DataNascimento;
        private int Altura;

        public int GetAltura() => Altura;
        public void SetAltura(int altura) => Altura = altura;
        public DateTime GetDataNascimento() => DataNascimento;
        public void SetDataNascimento(DateTime dataNascimento) => DataNascimento = dataNascimento;
        public string GetNome() => Nome;
        public void SetNome(string nome) => Nome = nome;

        public void MostrarDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Altura: {Altura}cm");
            Console.WriteLine($"Data Nascimento: {DataNascimento.ToString("dd/MM/yyyy")}");
        }

        public int GetIdade()
        {
            var idade = DateTime.Now.Year - DataNascimento.Year;
            if (DateTime.Now.DayOfYear < DataNascimento.DayOfYear)
            {
                idade -= 1;
            }

            return idade;
        }
    }
}
